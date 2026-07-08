using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class MaskapaiReportService
{
    private readonly MaskapaiReportRepository _reportRepository;
    private readonly JadwalPenerbanganRepository _jadwalRepository;
    private readonly int _maskapaiId;

    public MaskapaiReportService(
        MaskapaiReportRepository reportRepository,
        JadwalPenerbanganRepository jadwalRepository,
        int maskapaiId)
    {
        _reportRepository = reportRepository;
        _jadwalRepository = jadwalRepository;
        _maskapaiId = maskapaiId;
    }

    public async Task<List<JadwalPenerbanganView>> GetJadwalAsync()
    {
        EnsureMaskapaiContext();
        return await _jadwalRepository.SearchByMaskapaiAsync(_maskapaiId, string.Empty);
    }

    public async Task<MaskapaiReportResult> GetReportAsync(
        DateTime mulai,
        DateTime sampai,
        int jadwalId,
        string status)
    {
        EnsureMaskapaiContext();
        ValidateFilter(mulai, sampai, status);
        await ValidateJadwalOwnershipAsync(jadwalId);

        return new MaskapaiReportResult
        {
            Ringkasan = await _reportRepository.GetRingkasanAsync(_maskapaiId, mulai, sampai, jadwalId),
            Transaksi = await _reportRepository.GetTransaksiAsync(_maskapaiId, mulai, sampai, jadwalId),
            RutePopuler = await _reportRepository.GetRutePopulerAsync(_maskapaiId, mulai, sampai, jadwalId)
        };
    }

    private static void ValidateFilter(DateTime mulai, DateTime sampai, string status)
    {
        if (mulai.Date > sampai.Date)
        {
            throw new InvalidOperationException("Tanggal mulai tidak boleh melebihi tanggal sampai.");
        }

        if (!string.IsNullOrWhiteSpace(status)
            && !status.Equals("Semua", StringComparison.OrdinalIgnoreCase)
            && !status.Equals("Paid", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException("Status laporan tidak valid.");
        }
    }

    private async Task ValidateJadwalOwnershipAsync(int jadwalId)
    {
        if (jadwalId <= 0)
        {
            return;
        }

        var belongsToMaskapai = await _jadwalRepository.BelongsToMaskapaiAsync(jadwalId, _maskapaiId);
        if (!belongsToMaskapai)
        {
            throw new InvalidOperationException("Jadwal yang dipilih bukan milik maskapai Anda.");
        }
    }

    private void EnsureMaskapaiContext()
    {
        if (_maskapaiId <= 0)
        {
            throw new InvalidOperationException("Session maskapai belum valid.");
        }
    }
}
