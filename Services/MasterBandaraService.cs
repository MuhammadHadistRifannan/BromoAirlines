using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MasterBandaraService
{
    private readonly BandaraRepository _bandaraRepository;
    private readonly NegaraRepository _negaraRepository;

    public MasterBandaraService(BandaraRepository bandaraRepository, NegaraRepository negaraRepository)
    {
        _bandaraRepository = bandaraRepository;
        _negaraRepository = negaraRepository;
    }

    public async Task<List<Negara>> GetNegaraAsync()
    {
        return await _negaraRepository.GetAllAsync();
    }

    public async Task<List<BandaraView>> SearchAsync(string keyword)
    {
        return string.IsNullOrWhiteSpace(keyword)
            ? await _bandaraRepository.GetAllAsync()
            : await _bandaraRepository.SearchAsync(keyword.Trim());
    }

    public async Task<BandaraServiceResult> AddAsync(Bandara bandara)
    {
        var validation = await ValidateAsync(bandara, 0);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _bandaraRepository.InsertAsync(Normalize(bandara));
        return BandaraServiceResult.Success("Bandara berhasil ditambahkan.");
    }

    public async Task<BandaraServiceResult> UpdateAsync(Bandara bandara)
    {
        if (bandara.ID <= 0)
        {
            return BandaraServiceResult.Failed("Pilih data bandara yang akan diedit.");
        }

        var validation = await ValidateAsync(bandara, bandara.ID);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _bandaraRepository.UpdateAsync(Normalize(bandara));
        return BandaraServiceResult.Success("Bandara berhasil diperbarui.");
    }

    public async Task<BandaraServiceResult> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return BandaraServiceResult.Failed("Pilih data bandara yang akan dihapus.");
        }

        try
        {
            await _bandaraRepository.DeleteAsync(id);
            return BandaraServiceResult.Success("Bandara berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return BandaraServiceResult.Failed("Bandara tidak dapat dihapus karena masih digunakan.");
        }
    }

    private async Task<BandaraServiceResult> ValidateAsync(Bandara bandara, int ignoredId)
    {
        if (string.IsNullOrWhiteSpace(bandara.Nama))
        {
            return BandaraServiceResult.Failed("Nama bandara wajib diisi.");
        }

        if (!IsValidKodeIata(bandara.KodeIATA))
        {
            return BandaraServiceResult.Failed("Kode IATA harus terdiri dari 3 huruf.");
        }

        if (string.IsNullOrWhiteSpace(bandara.Kota))
        {
            return BandaraServiceResult.Failed("Kota wajib diisi.");
        }

        if (bandara.NegaraID <= 0 || bandara.JumlahTerminal <= 0)
        {
            return BandaraServiceResult.Failed("Negara dan jumlah terminal wajib valid.");
        }

        if (string.IsNullOrWhiteSpace(bandara.Alamat))
        {
            return BandaraServiceResult.Failed("Alamat wajib diisi.");
        }

        return await ValidateUniqueKodeIataAsync(bandara.KodeIATA, ignoredId);
    }

    private async Task<BandaraServiceResult> ValidateUniqueKodeIataAsync(string kodeIATA, int ignoredId)
    {
        var isExists = await _bandaraRepository.IsKodeIataExistsAsync(kodeIATA.Trim(), ignoredId);
        return isExists
            ? BandaraServiceResult.Failed("Kode IATA sudah digunakan.")
            : BandaraServiceResult.Success(string.Empty);
    }

    private static bool IsValidKodeIata(string kodeIATA)
    {
        return kodeIATA.Trim().Length == 3 && kodeIATA.Trim().All(char.IsLetter);
    }

    private static Bandara Normalize(Bandara bandara)
    {
        return new Bandara
        {
            ID = bandara.ID,
            Nama = bandara.Nama.Trim(),
            KodeIATA = bandara.KodeIATA.Trim().ToUpperInvariant(),
            Kota = bandara.Kota.Trim(),
            NegaraID = bandara.NegaraID,
            JumlahTerminal = bandara.JumlahTerminal,
            Alamat = bandara.Alamat.Trim()
        };
    }
}
