using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class LaporanService
{
    private readonly LaporanRepository _laporanRepository;

    public LaporanService(LaporanRepository laporanRepository)
    {
        _laporanRepository = laporanRepository;
    }

    public async Task<LaporanRingkasan> GetRingkasanAsync(DateTime mulai, DateTime sampai)
    {
        ValidatePeriode(mulai, sampai);
        return await _laporanRepository.GetRingkasanAsync(mulai, sampai);
    }

    public async Task<List<LaporanTransaksiView>> GetTransaksiAsync(DateTime mulai, DateTime sampai)
    {
        ValidatePeriode(mulai, sampai);
        return await _laporanRepository.GetTransaksiAsync(mulai, sampai);
    }

    public async Task<List<LaporanMaskapaiView>> GetMaskapaiAsync(DateTime mulai, DateTime sampai)
    {
        ValidatePeriode(mulai, sampai);
        return await _laporanRepository.GetMaskapaiAsync(mulai, sampai);
    }

    private static void ValidatePeriode(DateTime mulai, DateTime sampai)
    {
        if (mulai.Date > sampai.Date)
        {
            throw new InvalidOperationException("Tanggal mulai tidak boleh melebihi tanggal sampai.");
        }
    }
}
