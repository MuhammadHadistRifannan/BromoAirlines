using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class StatusPenerbanganRepository
{
    public async Task<List<StatusPenerbangan>> GetAllAsync()
    {
        var statusPenerbangan = new List<StatusPenerbangan>();
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            "SELECT ID, Nama FROM StatusPenerbangan ORDER BY ID",
            connection);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            statusPenerbangan.Add(new StatusPenerbangan
            {
                ID = reader.GetInt32(0),
                Nama = reader.GetString(1)
            });
        }

        return statusPenerbangan;
    }
}
