using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class UserSearchFlightService
{
    private readonly BandaraRepository _bandaraRepository;
    private readonly JadwalPenerbanganRepository _jadwalRepository;
    private readonly MaskapaiRepository _maskapaiRepository;

    public UserSearchFlightService(
        BandaraRepository bandaraRepository,
        JadwalPenerbanganRepository jadwalRepository,
        MaskapaiRepository maskapaiRepository)
    {
        _bandaraRepository = bandaraRepository;
        _jadwalRepository = jadwalRepository;
        _maskapaiRepository = maskapaiRepository;
    }

    public async Task<List<BandaraView>> GetBandaraAsync()
    {
        return await _bandaraRepository.GetAllAsync();
    }

    public async Task<List<Maskapai>> GetMaskapaiAsync()
    {
        return await _maskapaiRepository.GetAllAsync();
    }

    public async Task<List<JadwalPenerbanganView>> GetTopFlightsAsync(int limit)
    {
        return await _jadwalRepository.GetTopForUserAsync(limit);
    }

    public async Task<UserSearchFlightServiceResult> SearchAsync(
        int bandaraAsalId,
        int bandaraTujuanId,
        DateTime tanggalBerangkat,
        int jumlahPenumpang,
        int maskapaiId,
        bool useTanggal)
    {
        var validation = ValidateSearch(
            bandaraAsalId,
            bandaraTujuanId,
            tanggalBerangkat,
            jumlahPenumpang,
            useTanggal);

        if (!validation.IsSuccess)
        {
            return validation;
        }

        var jadwal = await _jadwalRepository.SearchForUserAsync(
            bandaraAsalId,
            bandaraTujuanId,
            tanggalBerangkat,
            maskapaiId,
            useTanggal);

        return UserSearchFlightServiceResult.Success(jadwal);
    }

    private static UserSearchFlightServiceResult ValidateSearch(
        int bandaraAsalId,
        int bandaraTujuanId,
        DateTime tanggalBerangkat,
        int jumlahPenumpang,
        bool useTanggal)
    {
        if (bandaraAsalId > 0 && bandaraTujuanId > 0 && bandaraAsalId == bandaraTujuanId)
        {
            return UserSearchFlightServiceResult.Failed("Bandara asal dan tujuan harus berbeda.");
        }

        if (useTanggal && tanggalBerangkat.Date < DateTime.Today)
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
