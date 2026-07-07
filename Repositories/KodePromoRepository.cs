using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class KodePromoRepository
{
    public async Task<List<KodePromo>> GetAllAsync()
    {
        return await SearchAsync(string.Empty);
    }

    public async Task<List<KodePromo>> GetActiveAsync(DateTime tanggal)
    {
        var kodePromo = new List<KodePromo>();
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT ID, Kode, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi
            FROM KodePromo
            WHERE BerlakuSampai >= @Tanggal
            ORDER BY BerlakuSampai, Kode
            """,
            connection);

        command.Parameters.AddWithValue("@Tanggal", tanggal.Date);
        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            kodePromo.Add(MapKodePromo(reader));
        }

        return kodePromo;
    }

    public async Task<List<KodePromo>> SearchAsync(string keyword)
    {
        var kodePromo = new List<KodePromo>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            kodePromo.Add(MapKodePromo(reader));
        }

        return kodePromo;
    }

    public async Task InsertAsync(KodePromo kodePromo)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO KodePromo (Kode, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi)
            VALUES (@Kode, @PersentaseDiskon, @MaksimumDiskon, @BerlakuSampai, @Deskripsi)
            """,
            connection);

        AddKodePromoParameters(command, kodePromo);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(KodePromo kodePromo)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            UPDATE KodePromo
            SET Kode = @Kode,
                PersentaseDiskon = @PersentaseDiskon,
                MaksimumDiskon = @MaksimumDiskon,
                BerlakuSampai = @BerlakuSampai,
                Deskripsi = @Deskripsi
            WHERE ID = @ID
            """,
            connection);

        AddKodePromoParameters(command, kodePromo);
        command.Parameters.AddWithValue("@ID", kodePromo.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand("DELETE FROM KodePromo WHERE ID = @ID", connection);

        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> IsKodeExistsAsync(string kode, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM KodePromo
            WHERE UPPER(Kode) = UPPER(@Kode) AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@Kode", kode);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT ID, Kode, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi
            FROM KodePromo
            WHERE @Keyword = ''
               OR Kode LIKE @Search
               OR Deskripsi LIKE @Search
            ORDER BY BerlakuSampai DESC, Kode
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static KodePromo MapKodePromo(System.Data.Common.DbDataReader reader)
    {
        return new KodePromo
        {
            ID = reader.GetInt32(0),
            Kode = reader.GetString(1),
            PersentaseDiskon = reader.GetDouble(2),
            MaksimumDiskon = reader.GetDouble(3),
            BerlakuSampai = reader.GetDateTime(4),
            Deskripsi = reader.GetString(5)
        };
    }

    private static void AddKodePromoParameters(MySqlCommand command, KodePromo kodePromo)
    {
        command.Parameters.AddWithValue("@Kode", kodePromo.Kode);
        command.Parameters.AddWithValue("@PersentaseDiskon", kodePromo.PersentaseDiskon);
        command.Parameters.AddWithValue("@MaksimumDiskon", kodePromo.MaksimumDiskon);
        command.Parameters.AddWithValue("@BerlakuSampai", kodePromo.BerlakuSampai.Date);
        command.Parameters.AddWithValue("@Deskripsi", kodePromo.Deskripsi);
    }
}
