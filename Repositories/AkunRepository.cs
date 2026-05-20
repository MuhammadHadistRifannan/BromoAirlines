using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class AkunRepository
{
    public Akun? FindByUsernameAndPassword(string username, string password)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT ID, Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin
            FROM Akun
            WHERE Username = @Username AND Password = @Password
            LIMIT 1
            """,
            connection);

        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Password", password);

        connection.Open();
        using var reader = command.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        return new Akun
        {
            ID = reader.GetInt32(0),
            Username = reader.GetString(1),
            Password = reader.GetString(2),
            Nama = reader.GetString(3),
            TanggalLahir = reader.GetDateTime(4),
            NomorTelepon = reader.GetString(5),
            MerupakanAdmin = reader.GetBoolean(6)
        };
    }
}
