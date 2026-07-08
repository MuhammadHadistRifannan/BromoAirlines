using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class MaskapaiDashboardRepository
{
    public async Task<MaskapaiDashboardSummary> GetSummaryAsync(int maskapaiId, DateTime today)
    {
        using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        return new MaskapaiDashboardSummary
        {
            MaskapaiName = await ExecuteStringAsync(connection, CreateMaskapaiNameCommand(connection, maskapaiId)),
            TodayFlights = await ExecuteIntAsync(connection, CreateTodayFlightsCommand(connection, maskapaiId, today)),
            ActiveFlights = await ExecuteIntAsync(connection, CreateActiveFlightsCommand(connection, maskapaiId, today)),
            TodayRevenue = await ExecuteDoubleAsync(connection, CreateTodayRevenueCommand(connection, maskapaiId, today)),
            TotalBookings = await ExecuteIntAsync(connection, CreateTotalBookingsCommand(connection, maskapaiId)),
            ActivePromo = await ExecuteIntAsync(connection, CreateActivePromoCommand(connection, maskapaiId, today)),
            RecentTransactions = await GetRecentTransactionsAsync(connection, maskapaiId)
        };
    }

    private static MySqlCommand CreateMaskapaiNameCommand(MySqlConnection connection, int maskapaiId)
    {
        var command = new MySqlCommand(
            """
            SELECT Nama
            FROM Maskapai
            WHERE ID = @MaskapaiID
            LIMIT 1
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        return command;
    }

    private static MySqlCommand CreateTodayFlightsCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime today)
    {
        var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM JadwalPenerbangan
            WHERE MaskapaiID = @MaskapaiID
              AND DATE(TanggalWaktuKeberangkatan) = @Today
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        command.Parameters.AddWithValue("@Today", today.Date);
        return command;
    }

    private static MySqlCommand CreateActiveFlightsCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime today)
    {
        var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM JadwalPenerbangan
            WHERE MaskapaiID = @MaskapaiID
              AND TanggalWaktuKeberangkatan >= @Now
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        command.Parameters.AddWithValue("@Now", today);
        return command;
    }

    private static MySqlCommand CreateTodayRevenueCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime today)
    {
        var command = new MySqlCommand(
            """
            SELECT COALESCE(SUM(TotalHarga), 0)
            FROM TransaksiHeader
            WHERE MaskapaiID = @MaskapaiID
              AND TanggalTransaksi >= @StartDate
              AND TanggalTransaksi < @EndDate
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        command.Parameters.AddWithValue("@StartDate", today.Date);
        command.Parameters.AddWithValue("@EndDate", today.Date.AddDays(1));
        return command;
    }

    private static MySqlCommand CreateTotalBookingsCommand(MySqlConnection connection, int maskapaiId)
    {
        var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM TransaksiHeader
            WHERE MaskapaiID = @MaskapaiID
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        return command;
    }

    private static MySqlCommand CreateActivePromoCommand(
        MySqlConnection connection,
        int maskapaiId,
        DateTime today)
    {
        var command = new MySqlCommand(
            """
            SELECT COUNT(1)
            FROM KodePromo
            WHERE MaskapaiID = @MaskapaiID
              AND BerlakuSampai >= @Today
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        command.Parameters.AddWithValue("@Today", today.Date);
        return command;
    }

    private static async Task<List<LaporanTransaksiView>> GetRecentTransactionsAsync(
        MySqlConnection connection,
        int maskapaiId)
    {
        var transaksi = new List<LaporanTransaksiView>();
        using var command = new MySqlCommand(
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
            ORDER BY th.TanggalTransaksi DESC, th.ID DESC
            LIMIT 10
            """,
            connection);

        AddMaskapaiParameter(command, maskapaiId);
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            transaksi.Add(MapTransaksi(reader));
        }

        return transaksi;
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

    private static async Task<int> ExecuteIntAsync(MySqlConnection connection, MySqlCommand command)
    {
        using (command)
        {
            return Convert.ToInt32(await command.ExecuteScalarAsync());
        }
    }

    private static async Task<double> ExecuteDoubleAsync(MySqlConnection connection, MySqlCommand command)
    {
        using (command)
        {
            return Convert.ToDouble(await command.ExecuteScalarAsync());
        }
    }

    private static async Task<string> ExecuteStringAsync(MySqlConnection connection, MySqlCommand command)
    {
        using (command)
        {
            return Convert.ToString(await command.ExecuteScalarAsync()) ?? string.Empty;
        }
    }

    private static void AddMaskapaiParameter(MySqlCommand command, int maskapaiId)
    {
        command.Parameters.AddWithValue("@MaskapaiID", maskapaiId);
    }
}
