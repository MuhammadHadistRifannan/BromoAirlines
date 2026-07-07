using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class PerubahanStatusJadwalPenerbanganRepository
{
    public async Task<List<JadwalStatusView>> SearchJadwalStatusAsync(string keyword)
    {
        var jadwalStatus = new List<JadwalStatusView>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            jadwalStatus.Add(MapJadwalStatus(reader));
        }

        return jadwalStatus;
    }

    public async Task InsertAsync(PerubahanStatusJadwalPenerbangan perubahanStatus)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            INSERT INTO PerubahanStatusJadwalPenerbangan
            (JadwalPenerbanganID, StatusPenerbanganID, WaktuPerubahanTerjadi, PerkiraanDurasiDelay)
            VALUES
            (@JadwalPenerbanganID, @StatusPenerbanganID, @WaktuPerubahanTerjadi, @PerkiraanDurasiDelay)
            """,
            connection);

        AddPerubahanStatusParameters(command, perubahanStatus);
        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT jp.ID, jp.KodePenerbangan,
                   CONCAT(bk.KodeIATA, ' - ', bk.Nama) AS BandaraKeberangkatan,
                   CONCAT(bt.KodeIATA, ' - ', bt.Nama) AS BandaraTujuan,
                   m.Nama AS Maskapai, jp.TanggalWaktuKeberangkatan,
                   COALESCE(ps.ID, 1) AS StatusPenerbanganID,
                   COALESCE(ps.Nama, 'Sesuai Jadwal') AS StatusPenerbangan,
                   latest.WaktuPerubahanTerjadi, latest.PerkiraanDurasiDelay
            FROM JadwalPenerbangan jp
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            LEFT JOIN (
                SELECT psj.*
                FROM PerubahanStatusJadwalPenerbangan psj
                INNER JOIN (
                    SELECT JadwalPenerbanganID, MAX(ID) AS LatestID
                    FROM PerubahanStatusJadwalPenerbangan
                    GROUP BY JadwalPenerbanganID
                ) lastStatus ON lastStatus.LatestID = psj.ID
            ) latest ON latest.JadwalPenerbanganID = jp.ID
            LEFT JOIN StatusPenerbangan ps ON ps.ID = latest.StatusPenerbanganID
            WHERE @Keyword = ''
               OR jp.KodePenerbangan LIKE @Search
               OR bk.Nama LIKE @Search
               OR bk.KodeIATA LIKE @Search
               OR bt.Nama LIKE @Search
               OR bt.KodeIATA LIKE @Search
               OR m.Nama LIKE @Search
               OR ps.Nama LIKE @Search
            ORDER BY jp.TanggalWaktuKeberangkatan DESC, jp.KodePenerbangan
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static JadwalStatusView MapJadwalStatus(System.Data.Common.DbDataReader reader)
    {
        return new JadwalStatusView
        {
            JadwalPenerbanganID = reader.GetInt32(0),
            KodePenerbangan = reader.GetString(1),
            BandaraKeberangkatan = reader.GetString(2),
            BandaraTujuan = reader.GetString(3),
            Maskapai = reader.GetString(4),
            TanggalWaktuKeberangkatan = reader.GetDateTime(5),
            StatusPenerbanganID = reader.GetInt32(6),
            StatusPenerbangan = reader.GetString(7),
            WaktuPerubahanTerjadi = reader.IsDBNull(8) ? null : reader.GetDateTime(8),
            PerkiraanDurasiDelay = reader.IsDBNull(9) ? null : reader.GetInt32(9)
        };
    }

    private static void AddPerubahanStatusParameters(
        MySqlCommand command,
        PerubahanStatusJadwalPenerbangan perubahanStatus)
    {
        command.Parameters.AddWithValue("@JadwalPenerbanganID", perubahanStatus.JadwalPenerbanganID);
        command.Parameters.AddWithValue("@StatusPenerbanganID", perubahanStatus.StatusPenerbanganID);
        command.Parameters.AddWithValue("@WaktuPerubahanTerjadi", perubahanStatus.WaktuPerubahanTerjadi);
        command.Parameters.AddWithValue(
            "@PerkiraanDurasiDelay",
            perubahanStatus.PerkiraanDurasiDelay ?? (object)DBNull.Value);
    }
}
