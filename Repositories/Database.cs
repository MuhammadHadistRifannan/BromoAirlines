using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public static class Database
{
    public static string ConnectionString { get; set; } =
        "Server=localhost;Port=3306;Database=BromoAirlines;Uid=root;Pwd=;SslMode=Disabled;";

    public static MySqlConnection CreateConnection()
    {
        return new MySqlConnection(ConnectionString);
    }
}
