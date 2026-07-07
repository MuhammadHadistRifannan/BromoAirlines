using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MasterMaskapaiService
{
    private readonly MaskapaiRepository _maskapaiRepository;

    public MasterMaskapaiService(MaskapaiRepository maskapaiRepository)
    {
        _maskapaiRepository = maskapaiRepository;
    }

    public async Task<List<Maskapai>> SearchAsync(string keyword)
    {
        return string.IsNullOrWhiteSpace(keyword)
            ? await _maskapaiRepository.GetAllAsync()
            : await _maskapaiRepository.SearchAsync(keyword.Trim());
    }

    public async Task<MaskapaiServiceResult> AddAsync(Maskapai maskapai)
    {
        var validation = await ValidateAsync(maskapai, 0);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _maskapaiRepository.InsertAsync(Normalize(maskapai));
        return MaskapaiServiceResult.Success("Maskapai berhasil ditambahkan.");
    }

    public async Task<MaskapaiServiceResult> UpdateAsync(Maskapai maskapai)
    {
        if (maskapai.ID <= 0)
        {
            return MaskapaiServiceResult.Failed("Pilih data maskapai yang akan diedit.");
        }

        var validation = await ValidateAsync(maskapai, maskapai.ID);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _maskapaiRepository.UpdateAsync(Normalize(maskapai));
        return MaskapaiServiceResult.Success("Maskapai berhasil diperbarui.");
    }

    public async Task<MaskapaiServiceResult> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return MaskapaiServiceResult.Failed("Pilih data maskapai yang akan dihapus.");
        }

        try
        {
            await _maskapaiRepository.DeleteAsync(id);
            return MaskapaiServiceResult.Success("Maskapai berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return MaskapaiServiceResult.Failed("Maskapai tidak dapat dihapus karena masih digunakan.");
        }
    }

    private async Task<MaskapaiServiceResult> ValidateAsync(Maskapai maskapai, int ignoredId)
    {
        if (string.IsNullOrWhiteSpace(maskapai.Nama))
        {
            return MaskapaiServiceResult.Failed("Nama maskapai wajib diisi.");
        }

        if (string.IsNullOrWhiteSpace(maskapai.Perusahaan))
        {
            return MaskapaiServiceResult.Failed("Perusahaan wajib diisi.");
        }

        if (maskapai.JumlahKru <= 0)
        {
            return MaskapaiServiceResult.Failed("Jumlah kru harus lebih dari 0.");
        }

        if (string.IsNullOrWhiteSpace(maskapai.Deskripsi))
        {
            return MaskapaiServiceResult.Failed("Deskripsi wajib diisi.");
        }

        return await ValidateUniqueNamaAsync(maskapai.Nama, ignoredId);
    }

    private async Task<MaskapaiServiceResult> ValidateUniqueNamaAsync(string nama, int ignoredId)
    {
        var isExists = await _maskapaiRepository.IsNamaExistsAsync(nama.Trim(), ignoredId);
        return isExists
            ? MaskapaiServiceResult.Failed("Nama maskapai sudah digunakan.")
            : MaskapaiServiceResult.Success(string.Empty);
    }

    private static Maskapai Normalize(Maskapai maskapai)
    {
        return new Maskapai
        {
            ID = maskapai.ID,
            Nama = maskapai.Nama.Trim(),
            Perusahaan = maskapai.Perusahaan.Trim(),
            JumlahKru = maskapai.JumlahKru,
            Deskripsi = maskapai.Deskripsi.Trim()
        };
    }
}
