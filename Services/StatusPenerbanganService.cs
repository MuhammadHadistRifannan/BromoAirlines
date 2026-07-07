using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class StatusPenerbanganService
{
    private readonly PerubahanStatusJadwalPenerbanganRepository _perubahanStatusRepository;
    private readonly StatusPenerbanganRepository _statusPenerbanganRepository;

    public StatusPenerbanganService(
        PerubahanStatusJadwalPenerbanganRepository perubahanStatusRepository,
        StatusPenerbanganRepository statusPenerbanganRepository)
    {
        _perubahanStatusRepository = perubahanStatusRepository;
        _statusPenerbanganRepository = statusPenerbanganRepository;
    }

    public async Task<List<StatusPenerbangan>> GetStatusPenerbanganAsync()
    {
        return await _statusPenerbanganRepository.GetAllAsync();
    }

    public async Task<List<JadwalStatusView>> SearchJadwalStatusAsync(string keyword)
    {
        return await _perubahanStatusRepository.SearchJadwalStatusAsync(keyword.Trim());
    }

    public async Task<StatusPenerbanganServiceResult> ChangeStatusAsync(
        PerubahanStatusJadwalPenerbangan perubahanStatus,
        string statusName)
    {
        var validation = Validate(perubahanStatus, statusName);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        perubahanStatus.WaktuPerubahanTerjadi = DateTime.Now;
        perubahanStatus.PerkiraanDurasiDelay = NormalizeDelay(perubahanStatus, statusName);
        await _perubahanStatusRepository.InsertAsync(perubahanStatus);
        return StatusPenerbanganServiceResult.Success("Status penerbangan berhasil diperbarui.");
    }

    private static StatusPenerbanganServiceResult Validate(
        PerubahanStatusJadwalPenerbangan perubahanStatus,
        string statusName)
    {
        if (perubahanStatus.JadwalPenerbanganID <= 0)
        {
            return StatusPenerbanganServiceResult.Failed("Pilih jadwal penerbangan terlebih dahulu.");
        }

        if (perubahanStatus.StatusPenerbanganID <= 0)
        {
            return StatusPenerbanganServiceResult.Failed("Pilih status penerbangan terlebih dahulu.");
        }

        if (IsDelay(statusName) && !IsValidDelay(perubahanStatus.PerkiraanDurasiDelay))
        {
            return StatusPenerbanganServiceResult.Failed("Durasi delay harus lebih dari 0 menit.");
        }

        return StatusPenerbanganServiceResult.Success(string.Empty);
    }

    private static int? NormalizeDelay(
        PerubahanStatusJadwalPenerbangan perubahanStatus,
        string statusName)
    {
        return IsDelay(statusName) ? perubahanStatus.PerkiraanDurasiDelay : null;
    }

    private static bool IsDelay(string statusName)
    {
        return statusName.Equals("Delay", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsValidDelay(int? perkiraanDurasiDelay)
    {
        return perkiraanDurasiDelay.HasValue && perkiraanDurasiDelay.Value > 0;
    }
}
