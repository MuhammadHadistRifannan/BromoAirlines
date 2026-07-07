using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class UserSearchFlightService
{
    private readonly BandaraRepository _bandaraRepository;
    private readonly JadwalPenerbanganRepository _jadwalRepository;

    public UserSearchFlightService(
        BandaraRepository bandaraRepository,
        JadwalPenerbanganRepository jadwalRepository)
    {
        _bandaraRepository = bandaraRepository;
        _jadwalRepository = jadwalRepository;
    }

    public async Task<List<BandaraView>> GetBandaraAsync()
    {
        return await _bandaraRepository.GetAllAsync();
    }

    public async Task<List<JadwalPenerbanganView>> GetTopFlightsAsync(int limit)
    {
        return await _jadwalRepository.GetTopForUserAsync(limit);
    }

    public async Task<UserSearchFlightServiceResult> SearchAsync(
        int bandaraAsalId,
        int bandaraTujuanId,
        DateTime tanggalBerangkat,
        int jumlahPenumpang)
    {
        var validation = ValidateSearch(
            bandaraAsalId,
            bandaraTujuanId,
            tanggalBerangkat,
            jumlahPenumpang);

        if (!validation.IsSuccess)
        {
            return validation;
        }

        var jadwal = await _jadwalRepository.SearchForUserAsync(
            bandaraAsalId,
            bandaraTujuanId,
            tanggalBerangkat);

        return UserSearchFlightServiceResult.Success(jadwal);
    }

    private static UserSearchFlightServiceResult ValidateSearch(
        int bandaraAsalId,
        int bandaraTujuanId,
        DateTime tanggalBerangkat,
        int jumlahPenumpang)
    {
        if (bandaraAsalId <= 0 || bandaraTujuanId <= 0)
        {
            return UserSearchFlightServiceResult.Failed("Bandara asal dan tujuan wajib dipilih.");
        }

        if (bandaraAsalId == bandaraTujuanId)
        {
            return UserSearchFlightServiceResult.Failed("Bandara asal dan tujuan harus berbeda.");
        }

        if (tanggalBerangkat.Date < DateTime.Today)
        {
            return UserSearchFlightServiceResult.Failed("Tanggal berangkat tidak boleh kurang dari hari ini.");
        }

        if (jumlahPenumpang < 1)
        {
            return UserSearchFlightServiceResult.Failed("Jumlah penumpang minimal 1.");
        }

        return UserSearchFlightServiceResult.Success(new List<JadwalPenerbanganView>());
    }
}
