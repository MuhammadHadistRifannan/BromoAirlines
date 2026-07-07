using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class JadwalPenerbanganRepository
{
    public async Task<List<JadwalPenerbanganView>> GetAllAsync()
    {
        return await SearchAsync(string.Empty);
    }

    public async Task<List<JadwalPenerbanganView>> SearchAsync(string keyword)
    {
        var jadwal = new List<JadwalPenerbanganView>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            jadwal.Add(MapJadwalView(reader));
        }

        return jadwal;
    }

    public async Task InsertAsync(JadwalPenerbangan jadwal)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO JadwalPenerbangan
            (KodePenerbangan, BandaraKeberangkatanID, BandaraTujuanID, MaskapaiID,
             TanggalWaktuKeberangkatan, DurasiPenerbangan, HargaPerTiket)
            VALUES
            (@KodePenerbangan, @BandaraKeberangkatanID, @BandaraTujuanID, @MaskapaiID,
             @TanggalWaktuKeberangkatan, @DurasiPenerbangan, @HargaPerTiket)
            """,
            connection);

        AddJadwalParameters(command, jadwal);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(JadwalPenerbangan jadwal)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            UPDATE JadwalPenerbangan
            SET KodePenerbangan = @KodePenerbangan,
                BandaraKeberangkatanID = @BandaraKeberangkatanID,
                BandaraTujuanID = @BandaraTujuanID,
                MaskapaiID = @MaskapaiID,
                TanggalWaktuKeberangkatan = @TanggalWaktuKeberangkatan,
                DurasiPenerbangan = @DurasiPenerbangan,
                HargaPerTiket = @HargaPerTiket
            WHERE ID = @ID
            """,
            connection);

        AddJadwalParameters(command, jadwal);
        command.Parameters.AddWithValue("@ID", jadwal.ID);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand("DELETE FROM JadwalPenerbangan WHERE ID = @ID", connection);

        command.Parameters.AddWithValue("@ID", id);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> IsKodePenerbanganExistsAsync(string kodePenerbangan, int ignoredId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM JadwalPenerbangan
            WHERE UPPER(KodePenerbangan) = UPPER(@KodePenerbangan) AND ID <> @IgnoredID
            """,
            connection);

        command.Parameters.AddWithValue("@KodePenerbangan", kodePenerbangan);
        command.Parameters.AddWithValue("@IgnoredID", ignoredId);
        await connection.OpenAsync();
        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT jp.ID, jp.KodePenerbangan,
                   jp.BandaraKeberangkatanID, CONCAT(bk.KodeIATA, ' - ', bk.Nama) AS BandaraKeberangkatan,
                   jp.BandaraTujuanID, CONCAT(bt.KodeIATA, ' - ', bt.Nama) AS BandaraTujuan,
                   jp.MaskapaiID, m.Nama AS Maskapai,
                   jp.TanggalWaktuKeberangkatan, jp.DurasiPenerbangan, jp.HargaPerTiket
            FROM JadwalPenerbangan jp
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            WHERE @Keyword = ''
               OR jp.KodePenerbangan LIKE @Search
               OR bk.Nama LIKE @Search
               OR bk.KodeIATA LIKE @Search
               OR bt.Nama LIKE @Search
               OR bt.KodeIATA LIKE @Search
               OR m.Nama LIKE @Search
            ORDER BY jp.TanggalWaktuKeberangkatan DESC, jp.KodePenerbangan
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static JadwalPenerbanganView MapJadwalView(System.Data.Common.DbDataReader reader)
    {
        return new JadwalPenerbanganView
        {
            ID = reader.GetInt32(0),
            KodePenerbangan = reader.GetString(1),
            BandaraKeberangkatanID = reader.GetInt32(2),
            BandaraKeberangkatan = reader.GetString(3),
            BandaraTujuanID = reader.GetInt32(4),
            BandaraTujuan = reader.GetString(5),
            MaskapaiID = reader.GetInt32(6),
            Maskapai = reader.GetString(7),
            TanggalWaktuKeberangkatan = reader.GetDateTime(8),
            DurasiPenerbangan = reader.GetInt32(9),
            HargaPerTiket = reader.GetDouble(10)
        };
    }

    private static void AddJadwalParameters(MySqlCommand command, JadwalPenerbangan jadwal)
    {
        command.Parameters.AddWithValue("@KodePenerbangan", jadwal.KodePenerbangan);
        command.Parameters.AddWithValue("@BandaraKeberangkatanID", jadwal.BandaraKeberangkatanID);
        command.Parameters.AddWithValue("@BandaraTujuanID", jadwal.BandaraTujuanID);
        command.Parameters.AddWithValue("@MaskapaiID", jadwal.MaskapaiID);
        command.Parameters.AddWithValue("@TanggalWaktuKeberangkatan", jadwal.TanggalWaktuKeberangkatan);
        command.Parameters.AddWithValue("@DurasiPenerbangan", jadwal.DurasiPenerbangan);
        command.Parameters.AddWithValue("@HargaPerTiket", jadwal.HargaPerTiket);
    }
}
