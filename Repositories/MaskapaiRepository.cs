using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class MaskapaiRepository
{
    public async Task<List<Maskapai>> GetAllAsync()
    {
        return await SearchAsync(string.Empty);
    }

    public async Task<List<Maskapai>> SearchAsync(string keyword)
    {
        var maskapai = new List<Maskapai>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            maskapai.Add(MapMaskapai(reader));
        }

        return maskapai;
    }

    public async Task InsertAsync(Maskapai maskapai)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO Maskapai (Nama, Perusahaan, JumlahKru, Deskripsi)
            VALUES (@Nama, @Perusahaan, @JumlahKru, @Deskripsi)
            """,
            connection);

        AddMaskapaiParameters(command, maskapai);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Maskapai maskapai)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            UPDATE Maskapai
            SET Nama = @Nama,
                Perusahaan = @Perusahaan,
                JumlahKru = @JumlahKru,
                Deskripsi = @Deskripsi
            WHERE ID = @ID
            """,
            connection);

        AddMaskapaiParameters(command, maskapai);
        command.Parameters.AddWithValue("@ID", maskapai.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand("DELETE FROM Maskapai WHERE ID = @ID", connection);

        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> IsNamaExistsAsync(string nama, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM Maskapai
            WHERE UPPER(Nama) = UPPER(@Nama) AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@Nama", nama);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT ID, Nama, Perusahaan, JumlahKru, Deskripsi
            FROM Maskapai
            WHERE @Keyword = ''
               OR Nama LIKE @Search
               OR Perusahaan LIKE @Search
               OR Deskripsi LIKE @Search
            ORDER BY Nama
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static Maskapai MapMaskapai(System.Data.Common.DbDataReader reader)
    {
        return new Maskapai
        {
            ID = reader.GetInt32(0),
            Nama = reader.GetString(1),
            Perusahaan = reader.GetString(2),
            JumlahKru = reader.GetInt32(3),
            Deskripsi = reader.GetString(4)
        };
    }

    private static void AddMaskapaiParameters(MySqlCommand command, Maskapai maskapai)
    {
        command.Parameters.AddWithValue("@Nama", maskapai.Nama);
        command.Parameters.AddWithValue("@Perusahaan", maskapai.Perusahaan);
        command.Parameters.AddWithValue("@JumlahKru", maskapai.JumlahKru);
        command.Parameters.AddWithValue("@Deskripsi", maskapai.Deskripsi);
    }
}
