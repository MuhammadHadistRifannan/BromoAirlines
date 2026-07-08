using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class AkunRepository
{
    public async Task<Akun?> FindByIdAsync(int id)
    {
        using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        var hasEmail = await HasEmailColumnAsync(connection);
        using var command = CreateFindByIdCommand(connection, id, hasEmail);
        using var reader = await command.ExecuteReaderAsync();
        return await reader.ReadAsync() ? MapAkun(reader) : null;
    }

    public async Task<List<Akun>> SearchAsync(string keyword)
    {
        var akun = new List<Akun>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            akun.Add(MapAkun(reader));
        }

        return akun;
    }

    public async Task InsertAsync(Akun akun)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO Akun (Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin)
            VALUES (@Username, @Password, @Nama, @TanggalLahir, @NomorTelepon, @MerupakanAdmin)
            """,
            connection);

        AddAkunParameters(command, akun);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Akun akun)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            UPDATE Akun
            SET Username = @Username,
                Password = @Password,
                Nama = @Nama,
                TanggalLahir = @TanggalLahir,
                NomorTelepon = @NomorTelepon,
                MerupakanAdmin = @MerupakanAdmin
            WHERE ID = @ID
            """,
            connection);

        AddAkunParameters(command, akun);
        command.Parameters.AddWithValue("@ID", akun.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand("DELETE FROM Akun WHERE ID = @ID", connection);

        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> IsUsernameExistsAsync(string username, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM Akun
            WHERE UPPER(Username) = UPPER(@Username) AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    public async Task UpdateProfileAsync(Akun akun)
    {
        using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        var hasEmail = await HasEmailColumnAsync(connection);
        using var command = CreateUpdateProfileCommand(connection, akun, hasEmail);
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdatePasswordAsync(int id, string password)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            "UPDATE Akun SET Password = @Password WHERE ID = @ID",
            connection);

        command.Parameters.AddWithValue("@Password", password);
        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public Akun? FindByUsernameAndPassword(string username, string password)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT ID, Username, Password, Nama, '' AS Email, TanggalLahir, NomorTelepon, MerupakanAdmin
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

        return MapAkun(reader);
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT ID, Username, Password, Nama, '' AS Email, TanggalLahir, NomorTelepon, MerupakanAdmin
            FROM Akun
            WHERE @Keyword = ''
               OR Username LIKE @Search
               OR Nama LIKE @Search
               OR NomorTelepon LIKE @Search
            ORDER BY Nama
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static MySqlCommand CreateFindByIdCommand(MySqlConnection connection, int id, bool hasEmail)
    {
        var emailColumn = hasEmail ? "Email" : "NomorTelepon";
        var command = new MySqlCommand(
            $"""
            SELECT ID, Username, Password, Nama, {emailColumn} AS Email, TanggalLahir, NomorTelepon, MerupakanAdmin
            FROM Akun
            WHERE ID = @ID
            LIMIT 1
            """,
            connection);

        command.Parameters.AddWithValue("@ID", id);
        return command;
    }

    private static MySqlCommand CreateUpdateProfileCommand(MySqlConnection connection, Akun akun, bool hasEmail)
    {
        var emailAssignment = hasEmail ? "Email = @Email" : "NomorTelepon = @Email";
        var command = new MySqlCommand(
            $"""
            UPDATE Akun
            SET Username = @Username,
                Nama = @Nama,
                {emailAssignment}
            WHERE ID = @ID
            """,
            connection);

        command.Parameters.AddWithValue("@Username", akun.Username);
        command.Parameters.AddWithValue("@Nama", akun.Nama);
        command.Parameters.AddWithValue("@Email", akun.Email);
        command.Parameters.AddWithValue("@ID", akun.ID);
        return command;
    }

    private static Akun MapAkun(System.Data.Common.DbDataReader reader)
    {
        return new Akun
        {
            ID = reader.GetInt32(0),
            Username = reader.GetString(1),
            Password = reader.GetString(2),
            Nama = reader.GetString(3),
            Email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
            TanggalLahir = reader.GetDateTime(5),
            NomorTelepon = reader.GetString(6),
            MerupakanAdmin = reader.GetInt32(7)
        };
    }

    private static void AddAkunParameters(MySqlCommand command, Akun akun)
    {
        command.Parameters.AddWithValue("@Username", akun.Username);
        command.Parameters.AddWithValue("@Password", akun.Password);
        command.Parameters.AddWithValue("@Nama", akun.Nama);
        command.Parameters.AddWithValue("@TanggalLahir", akun.TanggalLahir.Date);
        command.Parameters.AddWithValue("@NomorTelepon", akun.NomorTelepon);
        command.Parameters.AddWithValue("@MerupakanAdmin", akun.MerupakanAdmin);
    }

    private static async Task<bool> HasEmailColumnAsync(MySqlConnection connection)
    {
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM INFORMATION_SCHEMA.COLUMNS
            WHERE TABLE_SCHEMA = DATABASE()
              AND TABLE_NAME = 'Akun'
              AND COLUMN_NAME = 'Email'
            """,
            connection);

        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }
}
