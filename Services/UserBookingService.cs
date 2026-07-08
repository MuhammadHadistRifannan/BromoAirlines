using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class UserBookingService
{
    private readonly KodePromoRepository _kodePromoRepository;

    public UserBookingService(KodePromoRepository kodePromoRepository)
    {
        _kodePromoRepository = kodePromoRepository;
    }

    public async Task<List<KodePromo>> GetActivePromosAsync()
    {
        return await _kodePromoRepository.GetActiveAsync(DateTime.Today);
    }

    public async Task<List<KodePromo>> GetActivePromosAsync(int maskapaiId)
    {
        if (maskapaiId <= 0)
        {
            return new List<KodePromo>();
        }

        return await _kodePromoRepository.GetActiveByMaskapaiAsync(maskapaiId, DateTime.Today);
    }

}
