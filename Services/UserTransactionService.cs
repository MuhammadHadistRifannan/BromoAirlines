using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class UserTransactionService
{
    private const double TaxRate = 0.11;
    private readonly TransaksiRepository _transaksiRepository;

    public UserTransactionService(TransaksiRepository transaksiRepository)
    {
        _transaksiRepository = transaksiRepository;
    }

    public double CalculateSubtotal(UserBookingContext context)
    {
        return context.Flight.HargaPerTiket * context.JumlahPenumpang;
    }

    public double CalculateTax(UserBookingContext context)
    {
        return CalculateSubtotal(context) * TaxRate;
    }

    public double CalculatePromo(UserBookingContext context)
    {
        if (context.Promo == null)
        {
            return 0;
        }

        var discount = CalculateSubtotal(context) * (context.Promo.PersentaseDiskon / 100);
        return Math.Min(discount, context.Promo.MaksimumDiskon);
    }

    public double CalculateTotal(UserBookingContext context)
    {
        return Math.Max(0, CalculateSubtotal(context) + CalculateTax(context) - CalculatePromo(context));
    }

    public async Task<UserTransactionServiceResult> PayAsync(int akunId, UserBookingContext context)
    {
        var validation = ValidatePayment(akunId, context);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        var header = CreateHeader(akunId, context);
        var details = CreateDetails(context.Passengers);
        var transaksiId = await _transaksiRepository.InsertAsync(header, details);
        return UserTransactionServiceResult.Success("Pembayaran berhasil dan tiket berhasil dibuat.", transaksiId);
    }

    public async Task<List<TransaksiView>> GetTicketsAsync(int akunId)
    {
        return await _transaksiRepository.SearchByUserAsync(akunId, "Paid", null, null);
    }

    public async Task<List<TransaksiView>> GetHistoryAsync(
        int akunId,
        DateTime? startDate,
        DateTime? endDate,
        string status)
    {
        return await _transaksiRepository.SearchByUserAsync(akunId, status, startDate, endDate);
    }

    public async Task<List<TransaksiDetail>> GetDetailsAsync(int transaksiHeaderId)
    {
        return await _transaksiRepository.GetDetailsAsync(transaksiHeaderId);
    }

    private UserTransactionServiceResult ValidatePayment(int akunId, UserBookingContext context)
    {
        if (akunId <= 0)
        {
            return UserTransactionServiceResult.Failed("User belum valid. Silakan login ulang.");
        }

        if (context.Flight.ID <= 0)
        {
            return UserTransactionServiceResult.Failed("Jadwal penerbangan belum dipilih.");
        }

        if (context.JumlahPenumpang <= 0 || context.Passengers.Count != context.JumlahPenumpang)
        {
            return UserTransactionServiceResult.Failed("Data penumpang belum sesuai jumlah booking.");
        }

        if (context.Passengers.Any(passenger => string.IsNullOrWhiteSpace(passenger.NamaLengkap)))
        {
            return UserTransactionServiceResult.Failed("Nama lengkap seluruh penumpang wajib diisi.");
        }

        return UserTransactionServiceResult.Success(string.Empty, 0);
    }

    private TransaksiHeader CreateHeader(int akunId, UserBookingContext context)
    {
        return new TransaksiHeader
        {
            AkunID = akunId,
            TanggalTransaksi = DateTime.Now,
            JadwalPenerbanganID = context.Flight.ID,
            JumlahPenumpang = context.JumlahPenumpang,
            MaskapaiID = context.Flight.MaskapaiID,
            TotalHarga = CalculateTotal(context),
            KodePromoID = context.Promo?.ID
        };
    }

    private static List<TransaksiDetail> CreateDetails(List<PassengerInputData> passengers)
    {
        return passengers.Select(passenger => new TransaksiDetail
        {
            TitelPenumpang = passenger.JenisKelamin.Equals("Perempuan", StringComparison.OrdinalIgnoreCase)
                ? "Nyonya"
                : "Tuan",
            NamaLengkapPenumpang = passenger.NamaLengkap.Trim()
        }).ToList();
    }
}
