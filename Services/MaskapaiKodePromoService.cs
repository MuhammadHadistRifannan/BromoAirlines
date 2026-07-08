using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class MaskapaiKodePromoService
{
    private readonly MaskapaiKodePromoRepository _kodePromoRepository;
    private readonly int _maskapaiId;

    public MaskapaiKodePromoService(MaskapaiKodePromoRepository kodePromoRepository, int maskapaiId)
    {
        _kodePromoRepository = kodePromoRepository;
        _maskapaiId = maskapaiId;
    }

    public async Task<List<KodePromo>> SearchAsync(string keyword)
    {
        EnsureMaskapaiContext();
        return await _kodePromoRepository.SearchByMaskapaiAsync(_maskapaiId, keyword.Trim());
    }

    public async Task<KodePromoServiceResult> AddAsync(KodePromo kodePromo)
    {
        SetMaskapaiFromSession(kodePromo);
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

        SetMaskapaiFromSession(kodePromo);
        var ownership = await ValidateOwnershipAsync(kodePromo.ID);
        if (!ownership.IsSuccess)
        {
            return ownership;
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

        var ownership = await ValidateOwnershipAsync(id);
        if (!ownership.IsSuccess)
        {
            return ownership;
        }

        try
        {
            await _kodePromoRepository.DeleteAsync(id, _maskapaiId);
            return KodePromoServiceResult.Success("Kode promo berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return KodePromoServiceResult.Failed("Kode promo tidak dapat dihapus karena sudah digunakan transaksi.");
        }
    }

    private async Task<KodePromoServiceResult> ValidateAsync(KodePromo kodePromo, int ignoredId)
    {
        if (_maskapaiId <= 0)
        {
            return KodePromoServiceResult.Failed("Session maskapai belum valid.");
        }

        if (string.IsNullOrWhiteSpace(kodePromo.Kode))
        {
            return KodePromoServiceResult.Failed("Kode promo wajib diisi.");
        }

        if (kodePromo.PersentaseDiskon <= 0 || kodePromo.PersentaseDiskon > 100)
        {
            return KodePromoServiceResult.Failed("Persentase diskon harus 1 sampai 100.");
        }

        if (kodePromo.MaksimumDiskon <= 0)
        {
            return KodePromoServiceResult.Failed("Maksimum diskon harus lebih dari 0.");
        }

        if (kodePromo.BerlakuSampai.Date < DateTime.Today)
        {
            return KodePromoServiceResult.Failed("Tanggal berlaku sampai tidak boleh lewat.");
        }

        var exists = await _kodePromoRepository.IsKodeExistsAsync(
            kodePromo.Kode.Trim(),
            _maskapaiId,
            ignoredId);

        return exists
            ? KodePromoServiceResult.Failed("Kode promo sudah digunakan oleh maskapai Anda.")
            : KodePromoServiceResult.Success(string.Empty);
    }

    private async Task<KodePromoServiceResult> ValidateOwnershipAsync(int id)
    {
        EnsureMaskapaiContext();
        var belongsToMaskapai = await _kodePromoRepository.BelongsToMaskapaiAsync(id, _maskapaiId);
        return belongsToMaskapai
            ? KodePromoServiceResult.Success(string.Empty)
            : KodePromoServiceResult.Failed("Kode promo ini bukan milik maskapai Anda.");
    }

    private void SetMaskapaiFromSession(KodePromo kodePromo)
    {
        kodePromo.MaskapaiID = _maskapaiId;
    }

    private void EnsureMaskapaiContext()
    {
        if (_maskapaiId <= 0)
        {
            throw new InvalidOperationException("Session maskapai belum valid.");
        }
    }

    private static KodePromo Normalize(KodePromo kodePromo)
    {
        return new KodePromo
        {
            ID = kodePromo.ID,
            MaskapaiID = kodePromo.MaskapaiID,
            Kode = kodePromo.Kode.Trim().ToUpperInvariant(),
            PersentaseDiskon = kodePromo.PersentaseDiskon,
            MaksimumDiskon = kodePromo.MaksimumDiskon,
            BerlakuSampai = kodePromo.BerlakuSampai.Date,
            Deskripsi = kodePromo.Deskripsi.Trim()
        };
    }
}
