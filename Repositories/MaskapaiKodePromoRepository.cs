using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class MaskapaiKodePromoRepository
{
    public async Task<List<KodePromo>> SearchByMaskapaiAsync(int maskapaiId, string keyword)
    {
        var promos = new List<KodePromo>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, maskapaiId, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            promos.Add(MapKodePromo(reader));
        }

        return promos;
    }

    public async Task InsertAsync(KodePromo kodePromo)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO KodePromo
            (Kode, MaskapaiID, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi)
            VALUES
            (@Kode, @MaskapaiID, @PersentaseDiskon, @MaksimumDiskon, @BerlakuSampai, @Deskripsi)
            """,
            connection);

        AddParameters(command, kodePromo);
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
            WHERE ID = @ID AND MaskapaiID = @MaskapaiID
            """,
            connection);

        AddParameters(command, kodePromo);
        command.Parameters.AddWithValue("@ID", kodePromo.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id, int maskapaiId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            "DELETE FROM KodePromo WHERE ID = @ID AND MaskapaiID = @MaskapaiID",
            connection);

        command.Parameters.AddWithValue("@ID", id);
        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> BelongsToMaskapaiAsync(int id, int maskapaiId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM KodePromo
            WHERE ID = @ID AND MaskapaiID = @MaskapaiID
            """,
            connection);

        command.Parameters.AddWithValue("@ID", id);
        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    public async Task<bool> IsKodeExistsAsync(string kode, int maskapaiId, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM KodePromo
            WHERE MaskapaiID = @MaskapaiID
              AND UPPER(Kode) = UPPER(@Kode)
              AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@Kode", kode);
        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    private static MySqlCommand CreateSearchCommand(
        MySqlConnection connection,
        int maskapaiId,
        string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT ID, Kode, MaskapaiID, PersentaseDiskon, MaksimumDiskon, BerlakuSampai, Deskripsi
            FROM KodePromo
            WHERE MaskapaiID = @MaskapaiID
              AND (@Keyword = ''
                   OR Kode LIKE @Search
                   OR Deskripsi LIKE @Search)
            ORDER BY BerlakuSampai DESC, Kode
            """,
            connection);

        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
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
            MaskapaiID = reader.GetInt32(2),
            PersentaseDiskon = reader.GetDouble(3),
            MaksimumDiskon = reader.GetDouble(4),
            BerlakuSampai = reader.GetDateTime(5),
            Deskripsi = reader.GetString(6)
        };
    }

    private static void AddParameters(MySqlCommand command, KodePromo kodePromo)
    {
        command.Parameters.AddWithValue("@Kode", kodePromo.Kode);
        command.Parameters.AddWithValue("@MaskapaiID", kodePromo.MaskapaiID);
        command.Parameters.AddWithValue("@PersentaseDiskon", kodePromo.PersentaseDiskon);
        command.Parameters.AddWithValue("@MaksimumDiskon", kodePromo.MaksimumDiskon);
        command.Parameters.AddWithValue("@BerlakuSampai", kodePromo.BerlakuSampai.Date);
        command.Parameters.AddWithValue("@Deskripsi", kodePromo.Deskripsi);
    }
}
