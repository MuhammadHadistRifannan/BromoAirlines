using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class NegaraRepository
{
    public async Task<List<Negara>> GetAllAsync()
    {
        var negara = new List<Negara>();
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            "SELECT ID, Nama, IbukotaNegara FROM Negara ORDER BY Nama",
            connection);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            negara.Add(new Negara
            {
                ID = reader.GetInt32(0),
                Nama = reader.GetString(1),
                IbukotaNegara = reader.GetString(2)
            });
        }

        return negara;
    }
}
