using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class MaskapaiReportRepository
{
    public async Task<LaporanRingkasan> GetRingkasanAsync(
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(1), COALESCE(SUM(JumlahPenumpang), 0), COALESCE(SUM(TotalHarga), 0)
            FROM TransaksiHeader
            WHERE MaskapaiID = @MaskapaiID
              AND TanggalTransaksi >= @Mulai
              AND TanggalTransaksi < @Sampai
              AND (@JadwalID = 0 OR JadwalPenerbanganID = @JadwalID)
            """,
            connection);

        AddFilterParameters(command, maskapaiId, mulai, sampai, jadwalId);
        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return new LaporanRingkasan();
        }

        return new LaporanRingkasan
        {
            TotalTransaksi = Convert.ToInt32(reader.GetValue(0)),
            TotalPenumpang = Convert.ToInt32(reader.GetValue(1)),
            TotalPendapatan = Convert.ToDouble(reader.GetValue(2))
        };
    }

    public async Task<List<LaporanTransaksiView>> GetTransaksiAsync(
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        var transaksi = new List<LaporanTransaksiView>();
        using var connection = Database.CreateConnection();
        using var command = CreateTransaksiCommand(connection, maskapaiId, mulai, sampai, jadwalId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            transaksi.Add(MapTransaksi(reader));
        }

        return transaksi;
    }

    public async Task<List<MaskapaiPopularRouteView>> GetRutePopulerAsync(
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        var routes = new List<MaskapaiPopularRouteView>();
        using var connection = Database.CreateConnection();
        using var command = CreatePopularRouteCommand(connection, maskapaiId, mulai, sampai, jadwalId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            routes.Add(new MaskapaiPopularRouteView
            {
                Rute = reader.GetString(0),
                TotalTransaksi = Convert.ToInt32(reader.GetValue(1)),
                TotalPenumpang = Convert.ToInt32(reader.GetValue(2)),
                TotalPendapatan = Convert.ToDouble(reader.GetValue(3))
            });
        }

        return routes;
    }

    private static MySqlCommand CreateTransaksiCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        var command = new MySqlCommand(
            """
            SELECT th.ID, th.TanggalTransaksi, a.Nama, jp.KodePenerbangan,
                   CONCAT(bk.KodeIATA, ' - ', bt.KodeIATA) AS Rute,
                   m.Nama AS Maskapai, th.JumlahPenumpang, th.TotalHarga,
                   COALESCE(kp.Kode, '-') AS KodePromo
            FROM TransaksiHeader th
            INNER JOIN Akun a ON a.ID = th.AkunID
            INNER JOIN JadwalPenerbangan jp ON jp.ID = th.JadwalPenerbanganID
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            INNER JOIN Maskapai m ON m.ID = th.MaskapaiID
            LEFT JOIN KodePromo kp ON kp.ID = th.KodePromoID
            WHERE th.MaskapaiID = @MaskapaiID
              AND th.TanggalTransaksi >= @Mulai
              AND th.TanggalTransaksi < @Sampai
              AND (@JadwalID = 0 OR th.JadwalPenerbanganID = @JadwalID)
            ORDER BY th.TanggalTransaksi DESC, th.ID DESC
            """,
            connection);

        AddFilterParameters(command, maskapaiId, mulai, sampai, jadwalId);
        return command;
    }

    private static MySqlCommand CreatePopularRouteCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        var command = new MySqlCommand(
            """
            SELECT CONCAT(bk.KodeIATA, ' - ', bt.KodeIATA) AS Rute,
                   COUNT(1) AS TotalTransaksi,
                   COALESCE(SUM(th.JumlahPenumpang), 0) AS TotalPenumpang,
                   COALESCE(SUM(th.TotalHarga), 0) AS TotalPendapatan
            FROM TransaksiHeader th
            INNER JOIN JadwalPenerbangan jp ON jp.ID = th.JadwalPenerbanganID
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            WHERE th.MaskapaiID = @MaskapaiID
              AND th.TanggalTransaksi >= @Mulai
              AND th.TanggalTransaksi < @Sampai
              AND (@JadwalID = 0 OR th.JadwalPenerbanganID = @JadwalID)
            GROUP BY bk.KodeIATA, bt.KodeIATA
            ORDER BY TotalPenumpang DESC, TotalTransaksi DESC, Rute
            LIMIT 10
            """,
            connection);

        AddFilterParameters(command, maskapaiId, mulai, sampai, jadwalId);
        return command;
    }

    private static LaporanTransaksiView MapTransaksi(System.Data.Common.DbDataReader reader)
    {
        return new LaporanTransaksiView
        {
            ID = reader.GetInt32(0),
            TanggalTransaksi = reader.GetDateTime(1),
            NamaAkun = reader.GetString(2),
            KodePenerbangan = reader.GetString(3),
            Rute = reader.GetString(4),
            Maskapai = reader.GetString(5),
            JumlahPenumpang = reader.GetInt32(6),
            TotalHarga = reader.GetDouble(7),
            KodePromo = reader.GetString(8)
        };
    }

    private static void AddFilterParameters(
        MySqlCommand command,
        int maskapaiId,
        DateTime mulai,
        DateTime sampai,
        int jadwalId)
    {
        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
        command.Parameters.AddWithValue("@Mulai", mulai.Date);
        command.Parameters.AddWithValue("@Sampai", sampai.Date.AddDays(1));
        command.Parameters.AddWithValue("@JadwalID", jadwalId);
    }
}
