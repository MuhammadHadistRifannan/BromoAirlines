using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MasterKodePromoService
{
    private readonly KodePromoRepository _kodePromoRepository;

    public MasterKodePromoService(KodePromoRepository kodePromoRepository)
    {
        _kodePromoRepository = kodePromoRepository;
    }

    public async Task<List<KodePromo>> SearchAsync(string keyword)
    {
        return string.IsNullOrWhiteSpace(keyword)
            ? await _kodePromoRepository.GetAllAsync()
            : await _kodePromoRepository.SearchAsync(keyword.Trim());
    }

    public async Task<KodePromoServiceResult> AddAsync(KodePromo kodePromo)
    {
        var validation = await ValidateAsync(kodePromo, 0);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _kodePromoRepository.InsertAsync(Normalize(kodePromo));
        return KodePromoServiceResult.Success("Kode promo berhasil ditambahkan.");
    }

    public async Task<KodePromoServiceResult> UpdateAsync(KodePromo kodePromo)
    {
        if (kodePromo.ID <= 0)
        {
            return KodePromoServiceResult.Failed("Pilih kode promo yang akan diedit.");
        }

        var validation = await ValidateAsync(kodePromo, kodePromo.ID);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _kodePromoRepository.UpdateAsync(Normalize(kodePromo));
        return KodePromoServiceResult.Success("Kode promo berhasil diperbarui.");
    }

    public async Task<KodePromoServiceResult> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return KodePromoServiceResult.Failed("Pilih kode promo yang akan dihapus.");
        }

        try
        {
            await _kodePromoRepository.DeleteAsync(id);
            return KodePromoServiceResult.Success("Kode promo berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return KodePromoServiceResult.Failed("Kode promo tidak dapat dihapus karena masih digunakan.");
        }
    }

    private async Task<KodePromoServiceResult> ValidateAsync(KodePromo kodePromo, int ignoredId)
    {
        if (string.IsNullOrWhiteSpace(kodePromo.Kode))
        {
            return KodePromoServiceResult.Failed("Kode promo wajib diisi.");
        }

        if (kodePromo.PersentaseDiskon <= 0 || kodePromo.PersentaseDiskon > 100)
        {
            return KodePromoServiceResult.Failed("Persentase diskon harus antara 1 sampai 100.");
        }

        if (kodePromo.MaksimumDiskon <= 0)
        {
            return KodePromoServiceResult.Failed("Maksimum diskon harus lebih dari 0.");
        }

        if (kodePromo.BerlakuSampai.Date < DateTime.Today)
        {
            return KodePromoServiceResult.Failed("Tanggal berlaku sampai tidak boleh lewat.");
        }

        return await ValidateUniqueKodeAsync(kodePromo.Kode, ignoredId);
    }

    private async Task<KodePromoServiceResult> ValidateUniqueKodeAsync(string kode, int ignoredId)
    {
        var isExists = await _kodePromoRepository.IsKodeExistsAsync(kode.Trim(), ignoredId);
        return isExists
            ? KodePromoServiceResult.Failed("Kode promo sudah digunakan.")
            : KodePromoServiceResult.Success(string.Empty);
    }

    private static KodePromo Normalize(KodePromo kodePromo)
    {
        return new KodePromo
        {
            ID = kodePromo.ID,
            Kode = kodePromo.Kode.Trim().ToUpperInvariant(),
            PersentaseDiskon = kodePromo.PersentaseDiskon,
            MaksimumDiskon = kodePromo.MaksimumDiskon,
            BerlakuSampai = kodePromo.BerlakuSampai.Date,
            Deskripsi = kodePromo.Deskripsi.Trim()
        };
    }
}
