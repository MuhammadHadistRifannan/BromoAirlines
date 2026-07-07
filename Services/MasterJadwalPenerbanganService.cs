using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MasterJadwalPenerbanganService
{
    private readonly JadwalPenerbanganRepository _jadwalRepository;
    private readonly BandaraRepository _bandaraRepository;
    private readonly MaskapaiRepository _maskapaiRepository;

    public MasterJadwalPenerbanganService(
        JadwalPenerbanganRepository jadwalRepository,
        BandaraRepository bandaraRepository,
        MaskapaiRepository maskapaiRepository)
    {
        _jadwalRepository = jadwalRepository;
        _bandaraRepository = bandaraRepository;
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

    public async Task<List<JadwalPenerbanganView>> SearchAsync(string keyword)
    {
        return string.IsNullOrWhiteSpace(keyword)
            ? await _jadwalRepository.GetAllAsync()
            : await _jadwalRepository.SearchAsync(keyword.Trim());
    }

    public async Task<JadwalPenerbanganServiceResult> AddAsync(JadwalPenerbangan jadwal)
    {
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

        try
        {
            await _jadwalRepository.DeleteAsync(id);
            return JadwalPenerbanganServiceResult.Success("Jadwal penerbangan berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return JadwalPenerbanganServiceResult.Failed("Jadwal tidak dapat dihapus karena masih digunakan.");
        }
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateAsync(JadwalPenerbangan jadwal, int ignoredId)
    {
        if (string.IsNullOrWhiteSpace(jadwal.KodePenerbangan))
        {
            return JadwalPenerbanganServiceResult.Failed("Kode penerbangan wajib diisi.");
        }

        if (jadwal.KodePenerbangan.Trim().Length > 10)
        {
            return JadwalPenerbanganServiceResult.Failed("Kode penerbangan maksimal 10 karakter.");
        }

        if (jadwal.BandaraKeberangkatanID <= 0 || jadwal.BandaraTujuanID <= 0 || jadwal.MaskapaiID <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Bandara dan maskapai wajib dipilih.");
        }

        if (jadwal.BandaraKeberangkatanID == jadwal.BandaraTujuanID)
        {
            return JadwalPenerbanganServiceResult.Failed("Bandara keberangkatan dan tujuan harus berbeda.");
        }

        if (jadwal.TanggalWaktuKeberangkatan < DateTime.Now)
        {
            return JadwalPenerbanganServiceResult.Failed("Tanggal keberangkatan tidak boleh lewat.");
        }

        return await ValidateNumericAndUniqueAsync(jadwal, ignoredId);
    }

    private async Task<JadwalPenerbanganServiceResult> ValidateNumericAndUniqueAsync(
        JadwalPenerbangan jadwal,
        int ignoredId)
    {
        if (jadwal.DurasiPenerbangan <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Durasi penerbangan harus lebih dari 0 menit.");
        }

        if (jadwal.HargaPerTiket <= 0)
        {
            return JadwalPenerbanganServiceResult.Failed("Harga per tiket harus lebih dari 0.");
        }

        var isExists = await _jadwalRepository.IsKodePenerbanganExistsAsync(
            jadwal.KodePenerbangan.Trim(),
            ignoredId);

        return isExists
            ? JadwalPenerbanganServiceResult.Failed("Kode penerbangan sudah digunakan.")
            : JadwalPenerbanganServiceResult.Success(string.Empty);
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
