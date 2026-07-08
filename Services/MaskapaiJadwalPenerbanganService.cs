using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MaskapaiJadwalPenerbanganService
{
    private readonly JadwalPenerbanganRepository _jadwalRepository;
    private readonly BandaraRepository _bandaraRepository;
    private readonly int _maskapaiId;

    public MaskapaiJadwalPenerbanganService(
        JadwalPenerbanganRepository jadwalRepository,
        BandaraRepository bandaraRepository,
        int maskapaiId)
    {
        _jadwalRepository = jadwalRepository;
        _bandaraRepository = bandaraRepository;
        _maskapaiId = maskapaiId;
    }

    public async Task<List<BandaraView>> GetBandaraAsync()
    {
        return await _bandaraRepository.GetAllAsync();
    }

    public async Task<List<JadwalPenerbanganView>> SearchAsync(string keyword)
    {
        EnsureMaskapaiContext();
        return await _jadwalRepository.SearchByMaskapaiAsync(_maskapaiId, keyword.Trim());
    }

    public async Task<JadwalPenerbanganServiceResult> AddAsync(JadwalPenerbangan jadwal)
    {
        SetMaskapaiFromSession(jadwal);
        var validation = await ValidateAsync(jadwal, 0);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _jadwalRepository.InsertAsync(Normalize(jadwal));
        return JadwalPenerbanganServiceResult.Success("Jadwal penerbangan berhasil ditambahkan.");
    }

    public async Task<JadwalPenerbanganServiceResult> UpdateAsync(JadwalPenerbangan jadwal)
    {
        if (jadwal.ID <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Pilih jadwal penerbangan yang akan diedit.");
        }

        SetMaskapaiFromSession(jadwal);
        var ownership = await ValidateOwnershipAsync(jadwal.ID);
        if (!ownership.IsSuccess)
        {
            return ownership;
        }

        var validation = await ValidateAsync(jadwal, jadwal.ID);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _jadwalRepository.UpdateAsync(Normalize(jadwal));
        return JadwalPenerbanganServiceResult.Success("Jadwal penerbangan berhasil diperbarui.");
    }

    public async Task<JadwalPenerbanganServiceResult> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Pilih jadwal penerbangan yang akan dihapus.");
        }

        var ownership = await ValidateOwnershipAsync(id);
        if (!ownership.IsSuccess)
        {
            return ownership;
        }

        try
        {
            await _jadwalRepository.DeleteByMaskapaiAsync(id, _maskapaiId);
            return JadwalPenerbanganServiceResult.Success("Jadwal penerbangan berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return JadwalPenerbanganServiceResult.Failed("Jadwal tidak dapat dihapus karena masih digunakan.");
        }
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateAsync(
        JadwalPenerbangan jadwal,
        int ignoredId)
    {
        var basicValidation = await ValidateBasicAsync(jadwal, ignoredId);
        if (!basicValidation.IsSuccess)
        {
            return basicValidation;
        }

        var hasOverlap = await _jadwalRepository.HasOverlapAsync(jadwal, ignoredId);
        return hasOverlap
            ? JadwalPenerbanganServiceResult.Failed("Jadwal penerbangan maskapai tidak boleh saling bertabrakan.")
            : JadwalPenerbanganServiceResult.Success(string.Empty);
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateBasicAsync(
        JadwalPenerbangan jadwal,
        int ignoredId)
    {
        if (_maskapaiId <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Session maskapai belum valid.");
        }

        if (string.IsNullOrWhiteSpace(jadwal.KodePenerbangan))
        {
            return JadwalPenerbanganServiceResult.Failed("Kode penerbangan wajib diisi.");
        }

        if (jadwal.BandaraKeberangkatanID <= 0 || jadwal.BandaraTujuanID <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Bandara wajib dipilih.");
        }

        return await ValidateScheduleRulesAsync(jadwal, ignoredId);
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateScheduleRulesAsync(
        JadwalPenerbangan jadwal,
        int ignoredId)
    {
        if (jadwal.BandaraKeberangkatanID == jadwal.BandaraTujuanID)
        {
            return JadwalPenerbanganServiceResult.Failed("Bandara keberangkatan dan tujuan harus berbeda.");
        }

        if (jadwal.TanggalWaktuKeberangkatan < DateTime.Now)
        {
            return JadwalPenerbanganServiceResult.Failed("Tanggal keberangkatan tidak boleh lewat.");
        }

        if (jadwal.DurasiPenerbangan <= 0 || jadwal.HargaPerTiket <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Durasi dan harga harus lebih dari 0.");
        }

        var exists = await _jadwalRepository.IsKodePenerbanganExistsAsync(jadwal.KodePenerbangan.Trim(), ignoredId);
        return exists
            ? JadwalPenerbanganServiceResult.Failed("Kode penerbangan sudah digunakan.")
            : JadwalPenerbanganServiceResult.Success(string.Empty);
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateOwnershipAsync(int id)
    {
        EnsureMaskapaiContext();
        var belongsToMaskapai = await _jadwalRepository.BelongsToMaskapaiAsync(id, _maskapaiId);
        return belongsToMaskapai
            ? JadwalPenerbanganServiceResult.Success(string.Empty)
            : JadwalPenerbanganServiceResult.Failed("Jadwal ini bukan milik maskapai Anda.");
    }

    private void SetMaskapaiFromSession(JadwalPenerbangan jadwal)
    {
        jadwal.MaskapaiID = _maskapaiId;
    }

    private void EnsureMaskapaiContext()
    {
        if (_maskapaiId <= 0)
        {
            throw new InvalidOperationException("Session maskapai belum valid.");
        }
    }

    private static JadwalPenerbangan Normalize(JadwalPenerbangan jadwal)
    {
        return new JadwalPenerbangan
        {
            ID = jadwal.ID,
            KodePenerbangan = jadwal.KodePenerbangan.Trim().ToUpperInvariant(),
            BandaraKeberangkatanID = jadwal.BandaraKeberangkatanID,
            BandaraTujuanID = jadwal.BandaraTujuanID,
            MaskapaiID = jadwal.MaskapaiID,
            TanggalWaktuKeberangkatan = jadwal.TanggalWaktuKeberangkatan,
            DurasiPenerbangan = jadwal.DurasiPenerbangan,
            HargaPerTiket = jadwal.HargaPerTiket
        };
    }
}
