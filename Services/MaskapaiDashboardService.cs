using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class MaskapaiDashboardService
{
    private readonly MaskapaiDashboardRepository _dashboardRepository;
    private readonly int _maskapaiId;

    public MaskapaiDashboardService(MaskapaiDashboardRepository dashboardRepository, int maskapaiId)
    {
        _dashboardRepository = dashboardRepository;
        _maskapaiId = maskapaiId;
    }

    public async Task<MaskapaiDashboardSummary> GetSummaryAsync()
    {
        EnsureMaskapaiContext();
        return await _dashboardRepository.GetSummaryAsync(_maskapaiId, DateTime.Now);
    }

    private void EnsureMaskapaiContext()
    {
        if (_maskapaiId <= 0)
        {
            throw new InvalidOperationException("Session maskapai belum valid.");
        }
    }
}
