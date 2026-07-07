using BromoAirlines.Models;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public sealed class LaporanRepository
{
    public async Task<LaporanRingkasan> GetRingkasanAsync(DateTime mulai, DateTime sampai)
    {
        using var connection = Database.CreateConnection();
        using var command = new MySqlCommand(
            """
            SELECT COUNT(*), COALESCE(SUM(JumlahPenumpang), 0), COALESCE(SUM(TotalHarga), 0)
            FROM TransaksiHeader
            WHERE TanggalTransaksi >= @Mulai AND TanggalTransaksi < @Sampai
            """,
            connection);

        AddDateParameters(command, mulai, sampai);
        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return new LaporanRingkasan();
        }

        return new LaporanRingkasan
        {
            TotalTransaksi = reader.GetInt32(0),
            TotalPenumpang = Convert.ToInt32(reader.GetValue(1)),
            TotalPendapatan = Convert.ToDouble(reader.GetValue(2))
        };
    }

    public async Task<List<LaporanTransaksiView>> GetTransaksiAsync(DateTime mulai, DateTime sampai)
    {
        var transaksi = new List<LaporanTransaksiView>();
        using var connection = Database.CreateConnection();
        using var command = CreateTransaksiCommand(connection, mulai, sampai);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            transaksi.Add(MapTransaksi(reader));
        }

        return transaksi;
    }

    public async Task<List<LaporanMaskapaiView>> GetMaskapaiAsync(DateTime mulai, DateTime sampai)
    {
        var maskapai = new List<LaporanMaskapaiView>();
        using var connection = Database.CreateConnection();
        using var command = CreateMaskapaiCommand(connection, mulai, sampai);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            maskapai.Add(new LaporanMaskapaiView
            {
                Maskapai = reader.GetString(0),
                TotalTransaksi = reader.GetInt32(1),
                TotalPenumpang = Convert.ToInt32(reader.GetValue(2)),
                TotalPendapatan = Convert.ToDouble(reader.GetValue(3))
            });
        }

        return maskapai;
    }

    private static MySqlCommand CreateTransaksiCommand(MySqlConnection connection, DateTime mulai, DateTime sampai)
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
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            LEFT JOIN KodePromo kp ON kp.ID = th.KodePromoID
            WHERE th.TanggalTransaksi >= @Mulai AND th.TanggalTransaksi < @Sampai
            ORDER BY th.TanggalTransaksi DESC, th.ID DESC
            """,
            connection);

        AddDateParameters(command, mulai, sampai);
        return command;
    }

    private static MySqlCommand CreateMaskapaiCommand(MySqlConnection connection, DateTime mulai, DateTime sampai)
    {
        var command = new MySqlCommand(
            """
            SELECT m.Nama, COUNT(*), COALESCE(SUM(th.JumlahPenumpang), 0), COALESCE(SUM(th.TotalHarga), 0)
            FROM TransaksiHeader th
            INNER JOIN JadwalPenerbangan jp ON jp.ID = th.JadwalPenerbanganID
            INNER JOIN Maskapai m ON m.ID = jp.MaskapaiID
            WHERE th.TanggalTransaksi >= @Mulai AND th.TanggalTransaksi < @Sampai
            GROUP BY m.Nama
            ORDER BY SUM(th.TotalHarga) DESC, m.Nama
            """,
            connection);

        AddDateParameters(command, mulai, sampai);
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

    private static void AddDateParameters(MySqlCommand command, DateTime mulai, DateTime sampai)
    {
        command.Parameters.AddWithValue("@Mulai", mulai.Date);
        command.Parameters.AddWithValue("@Sampai", sampai.Date.AddDays(1));
    }
}
