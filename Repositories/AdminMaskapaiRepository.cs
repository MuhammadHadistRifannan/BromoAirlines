using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class AdminMaskapaiRepository
{
    public AdminMaskapai? FindByUserId(int userId)
    {
        using var connection = Database.CreateConnection();
        using var command = CreateFindByUserIdCommand(connection, userId);

        connection.Open();
        using var reader = command.ExecuteReader();
        return reader.Read() ? MapAdminMaskapai(reader) : null;
    }

    public async Task<AdminMaskapai?> FindByUserIdAsync(int userId)
    {
        using var connection = Database.CreateConnection();
        using var command = CreateFindByUserIdCommand(connection, userId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        return await reader.ReadAsync() ? MapAdminMaskapai(reader) : null;
    }

    private static MySqlCommand CreateFindByUserIdCommand(MySqlConnection connection, int userId)
    {
        var command = new MySqlCommand(
            """
            SELECT ID, UserID, MaskapaiID
            FROM AdminMaskapai
            WHERE UserID = @UserID
            LIMIT 1
            """,
            connection);

        command.Parameters.AddWithValue("@UserID", userId);
        return command;
    }

    private static AdminMaskapai MapAdminMaskapai(System.Data.Common.DbDataReader reader)
    {
        return new AdminMaskapai
        {
            ID = reader.GetInt32(0),
            UserID = reader.GetInt32(1),
            MaskapaiID = reader.GetInt32(2)
        };
    }
}
