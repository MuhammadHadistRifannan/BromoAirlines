using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class BandaraRepository
{
    public async Task<List<BandaraView>> GetAllAsync()
    {
        return await SearchAsync(string.Empty);
    }

    public async Task<List<BandaraView>> SearchAsync(string keyword)
    {
        var bandara = new List<BandaraView>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            bandara.Add(MapBandaraView(reader));
        }

        return bandara;
    }

    public async Task InsertAsync(Bandara bandara)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO Bandara (Nama, KodeIATA, Kota, NegaraID, JumlahTerminal, Alamat)
            VALUES (@Nama, @KodeIATA, @Kota, @NegaraID, @JumlahTerminal, @Alamat)
            """,
            connection);

        AddBandaraParameters(command, bandara);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Bandara bandara)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            UPDATE Bandara
            SET Nama = @Nama,
                KodeIATA = @KodeIATA,
                Kota = @Kota,
                NegaraID = @NegaraID,
                JumlahTerminal = @JumlahTerminal,
                Alamat = @Alamat
            WHERE ID = @ID
            """,
            connection);

        AddBandaraParameters(command, bandara);
        command.Parameters.AddWithValue("@ID", bandara.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand("DELETE FROM Bandara WHERE ID = @ID", connection);

        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> IsKodeIataExistsAsync(string kodeIATA, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM Bandara
            WHERE UPPER(KodeIATA) = UPPER(@KodeIATA) AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@KodeIATA", kodeIATA);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT b.ID, b.Nama, b.KodeIATA, b.Kota, b.NegaraID, n.Nama AS NegaraNama,
                   b.JumlahTerminal, b.Alamat
            FROM Bandara b
            INNER JOIN Negara n ON n.ID = b.NegaraID
            WHERE @Keyword = ''
               OR b.Nama LIKE @Search
               OR b.KodeIATA LIKE @Search
               OR b.Kota LIKE @Search
               OR n.Nama LIKE @Search
            ORDER BY b.Nama
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static BandaraView MapBandaraView(System.Data.Common.DbDataReader reader)
    {
        return new BandaraView
        {
            ID = reader.GetInt32(0),
            Nama = reader.GetString(1),
            KodeIATA = reader.GetString(2),
            Kota = reader.GetString(3),
            NegaraID = reader.GetInt32(4),
            NegaraNama = reader.GetString(5),
            JumlahTerminal = reader.GetInt32(6),
            Alamat = reader.GetString(7)
        };
    }

    private static void AddBandaraParameters(MySqlCommand command, Bandara bandara)
    {
        command.Parameters.AddWithValue("@Nama", bandara.Nama);
        command.Parameters.AddWithValue("@KodeIATA", bandara.KodeIATA);
        command.Parameters.AddWithValue("@Kota", bandara.Kota);
        command.Parameters.AddWithValue("@NegaraID", bandara.NegaraID);
        command.Parameters.AddWithValue("@JumlahTerminal", bandara.JumlahTerminal);
        command.Parameters.AddWithValue("@Alamat", bandara.Alamat);
    }
}
