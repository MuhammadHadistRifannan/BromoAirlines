using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class TransaksiService
{
    private readonly TransaksiRepository _transaksiRepository;

    public TransaksiService(TransaksiRepository transaksiRepository)
    {
        _transaksiRepository = transaksiRepository;
    }

    public async Task<List<TransaksiView>> SearchAsync(string keyword)
    {
        return await _transaksiRepository.SearchAsync(keyword.Trim());
    }

    public async Task<List<TransaksiDetail>> GetDetailsAsync(int transaksiHeaderId)
    {
        return transaksiHeaderId <= 0
            ? []
            : await _transaksiRepository.GetDetailsAsync(transaksiHeaderId);
    }

    public async Task<TransaksiServiceResult> DeleteAsync(int transaksiHeaderId)
    {
        if (transaksiHeaderId <= 0)
        {
            return TransaksiServiceResult.Failed("Pilih transaksi yang akan dihapus.");
        }

        try
        {
            await _transaksiRepository.DeleteAsync(transaksiHeaderId);
            return TransaksiServiceResult.Success("Transaksi berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return TransaksiServiceResult.Failed("Transaksi belum dapat dihapus.");
        }
    }
}
