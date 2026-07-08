using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class TransaksiRepository
{
    public async Task<int> InsertAsync(TransaksiHeader transaksiHeader, List<TransaksiDetail> details)
    {
        using var connection = Database.CreateConnection();
        await connection.OpenAsync();
        using var transaction = await connection.BeginTransactionAsync();

        try
        {
            var transaksiHeaderId = await InsertHeaderAsync(connection, transaction, transaksiHeader);
            await InsertDetailsAsync(connection, transaction, transaksiHeaderId, details);
            await transaction.CommitAsync();
            return transaksiHeaderId;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task<List<TransaksiView>> SearchAsync(string keyword)
    {
        var transaksi = new List<TransaksiView>();
        using var connection = Database.CreateConnection();
        using var command = CreateSearchCommand(connection, keyword);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            transaksi.Add(MapTransaksi(reader));
        }

        return transaksi;
    }

    public async Task<List<TransaksiView>> SearchByUserAsync(int akunId, string status, DateTime? startDate, DateTime? endDate)
    {
        var transaksi = new List<TransaksiView>();
        using var connection = Database.CreateConnection();
        using var command = CreateUserSearchCommand(connection, akunId, startDate, endDate);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            transaksi.Add(MapTransaksi(reader));
        }

        return string.IsNullOrWhiteSpace(status) || status.Equals("Paid", StringComparison.OrdinalIgnoreCase)
            ? transaksi
            : new List<TransaksiView>();
    }

    public async Task<List<TransaksiDetail>> GetDetailsAsync(int transaksiHeaderId)
    {
        var details = new List<TransaksiDetail>();
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT ID, TransaksiHeaderID, TitelPenumpang, NamaLengkapPenumpang
            FROM TransaksiDetail
            WHERE TransaksiHeaderID = @TransaksiHeaderID
            ORDER BY ID
            """,
            connection);

        command.Parameters.AddWithValue("@TransaksiHeaderID", transaksiHeaderId);
        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            details.Add(MapTransaksiDetail(reader));
        }

        return details;
    }

    public async Task DeleteAsync(int transaksiHeaderId)
    {
        using var connection = Database.CreateConnection();
        await connection.OpenAsync();
        using var transaction = await connection.BeginTransactionAsync();

        try
        {
            await DeleteDetailsAsync(connection, transaction, transaksiHeaderId);
            await DeleteHeaderAsync(connection, transaction, transaksiHeaderId);
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    private static async Task<int> InsertHeaderAsync(
        MySqlConnection connection,
        System.Data.Common.DbTransaction transaction,
        TransaksiHeader transaksiHeader)
    {
        using var command = new MySqlCommand(
            """
            INSERT INTO TransaksiHeader
            (AkunID, TanggalTransaksi, JadwalPenerbanganID, JumlahPenumpang, MaskapaiID, TotalHarga, KodePromoID)
            VALUES
            (@AkunID, @TanggalTransaksi, @JadwalPenerbanganID, @JumlahPenumpang, @MaskapaiID, @TotalHarga, @KodePromoID)
            """,
            connection,
            (MySqlTransaction)transaction);

        command.Parameters.AddWithValue("@AkunID", transaksiHeader.AkunID);
        command.Parameters.AddWithValue("@TanggalTransaksi", transaksiHeader.TanggalTransaksi);
        command.Parameters.AddWithValue("@JadwalPenerbanganID", transaksiHeader.JadwalPenerbanganID);
        command.Parameters.AddWithValue("@JumlahPenumpang", transaksiHeader.JumlahPenumpang);
        command.Parameters.AddWithValue("@MaskapaiID", transaksiHeader.MaskapaiID);
        command.Parameters.AddWithValue("@TotalHarga", transaksiHeader.TotalHarga);
        command.Parameters.AddWithValue("@KodePromoID", transaksiHeader.KodePromoID ?? (object)DBNull.Value);

        await command.ExecuteNonQueryAsync();
        return Convert.ToInt32(command.LastInsertedId);
    }

    private static async Task InsertDetailsAsync(
        MySqlConnection connection,
        System.Data.Common.DbTransaction transaction,
        int transaksiHeaderId,
        List<TransaksiDetail> details)
    {
        foreach (var detail in details)
        {
            using var command = new MySqlCommand(
                """
                INSERT INTO TransaksiDetail
                (TransaksiHeaderID, TitelPenumpang, NamaLengkapPenumpang)
                VALUES
                (@TransaksiHeaderID, @TitelPenumpang, @NamaLengkapPenumpang)
                """,
                connection,
                (MySqlTransaction)transaction);

            command.Parameters.AddWithValue("@TransaksiHeaderID", transaksiHeaderId);
            command.Parameters.AddWithValue("@TitelPenumpang", detail.TitelPenumpang);
            command.Parameters.AddWithValue("@NamaLengkapPenumpang", detail.NamaLengkapPenumpang);
            await command.ExecuteNonQueryAsync();
        }
    }

    private static MySqlCommand CreateSearchCommand(MySqlConnection connection, string keyword)
    {
        var command = new MySqlCommand(
            """
            SELECT th.ID, th.AkunID, a.Nama AS NamaAkun, th.TanggalTransaksi,
                   th.JadwalPenerbanganID, jp.KodePenerbangan,
                   CONCAT(bk.KodeIATA, ' - ', bt.KodeIATA) AS Rute,
                   m.Nama AS Maskapai, th.JumlahPenumpang, th.TotalHarga,
                   th.KodePromoID, COALESCE(kp.Kode, '-') AS KodePromo
            FROM TransaksiHeader th
            INNER JOIN Akun a ON a.ID = th.AkunID
            INNER JOIN JadwalPenerbangan jp ON jp.ID = th.JadwalPenerbanganID
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            LEFT JOIN KodePromo kp ON kp.ID = th.KodePromoID
            WHERE @Keyword = ''
               OR a.Nama LIKE @Search
               OR jp.KodePenerbangan LIKE @Search
               OR bk.KodeIATA LIKE @Search
               OR bt.KodeIATA LIKE @Search
               OR m.Nama LIKE @Search
               OR kp.Kode LIKE @Search
            ORDER BY th.TanggalTransaksi DESC, th.ID DESC
            """,
            connection);

        command.Parameters.AddWithValue("@Keyword", keyword.Trim());
        command.Parameters.AddWithValue("@Search", $"%{keyword.Trim()}%");
        return command;
    }

    private static MySqlCommand CreateUserSearchCommand(
        MySqlConnection connection,
        int akunId,
        DateTime? startDate,
        DateTime? endDate)
    {
        var command = new MySqlCommand(
            """
            SELECT th.ID, th.AkunID, a.Nama AS NamaAkun, th.TanggalTransaksi,
                   th.JadwalPenerbanganID, jp.KodePenerbangan,
                   CONCAT(bk.KodeIATA, ' - ', bt.KodeIATA) AS Rute,
                   m.Nama AS Maskapai, th.JumlahPenumpang, th.TotalHarga,
                   th.KodePromoID, COALESCE(kp.Kode, '-') AS KodePromo
            FROM TransaksiHeader th
            INNER JOIN Akun a ON a.ID = th.AkunID
            INNER JOIN JadwalPenerbangan jp ON jp.ID = th.JadwalPenerbanganID
            INNER JOIN Bandara bk ON bk.ID = jp.BandaraKeberangkatanID
            INNER JOIN Bandara bt ON bt.ID = jp.BandaraTujuanID
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            LEFT JOIN KodePromo kp ON kp.ID = th.KodePromoID
            WHERE th.AkunID = @AkunID
              AND (@StartDate IS NULL OR DATE(th.TanggalTransaksi) >= @StartDate)
              AND (@EndDate IS NULL OR DATE(th.TanggalTransaksi) <= @EndDate)
            ORDER BY th.TanggalTransaksi DESC, th.ID DESC
            """,
            connection);

        command.Parameters.AddWithValue("@AkunID", akunId);
        command.Parameters.AddWithValue("@StartDate", startDate?.Date ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@EndDate", endDate?.Date ?? (object)DBNull.Value);
        return command;
    }

    private static async Task DeleteDetailsAsync(
        MySqlConnection connection,
        System.Data.Common.DbTransaction transaction,
        int transaksiHeaderId)
    {
        using var command = new MySqlCommand(
            "DELETE FROM TransaksiDetail WHERE TransaksiHeaderID = @TransaksiHeaderID",
            connection,
            (MySqlTransaction)transaction);

        command.Parameters.AddWithValue("@TransaksiHeaderID", transaksiHeaderId);
        await command.ExecuteNonQueryAsync();
    }

    private static async Task DeleteHeaderAsync(
        MySqlConnection connection,
        System.Data.Common.DbTransaction transaction,
        int transaksiHeaderId)
    {
        using var command = new MySqlCommand(
            "DELETE FROM TransaksiHeader WHERE ID = @ID",
            connection,
            (MySqlTransaction)transaction);

        command.Parameters.AddWithValue("@ID", transaksiHeaderId);
        await command.ExecuteNonQueryAsync();
    }

    private static TransaksiView MapTransaksi(System.Data.Common.DbDataReader reader)
    {
        return new TransaksiView
        {
            ID = reader.GetInt32(0),
            AkunID = reader.GetInt32(1),
            NamaAkun = reader.GetString(2),
            TanggalTransaksi = reader.GetDateTime(3),
            JadwalPenerbanganID = reader.GetInt32(4),
            KodePenerbangan = reader.GetString(5),
            Rute = reader.GetString(6),
            Maskapai = reader.GetString(7),
            JumlahPenumpang = reader.GetInt32(8),
            TotalHarga = reader.GetDouble(9),
            KodePromoID = reader.IsDBNull(10) ? null : reader.GetInt32(10),
            KodePromo = reader.GetString(11)
        };
    }

    private static TransaksiDetail MapTransaksiDetail(System.Data.Common.DbDataReader reader)
    {
        return new TransaksiDetail
        {
            ID = reader.GetInt32(0),
            TransaksiHeaderID = reader.GetInt32(1),
            TitelPenumpang = reader.GetString(2),
            NamaLengkapPenumpang = reader.GetString(3)
        };
    }
}
