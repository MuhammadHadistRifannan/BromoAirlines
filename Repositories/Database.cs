using MySql.Data.MySqlClient;

namespace BromoAirlines.Repositories;

public static class Database
{
    static Database()
    {
        EnvLoader.Load();
        ConnectionString = BuildConnectionString();
    }

    public static string ConnectionString { get; set; }

    public static MySqlConnection CreateConnection()
    {
        return new MySqlConnection(ConnectionString);
    }

    private static string BuildConnectionString()
    {
        var builder = new MySqlConnectionStringBuilder
        {
            Server = GetEnv("DB_HOST", "localhost"),
            Port = uint.Parse(GetEnv("DB_PORT", "3306")),
            Database = GetEnv("DB_NAME", "BromoAirlines"),
            UserID = GetEnv("DB_USER", "root"),
            Password = GetEnv("DB_PASSWORD", string.Empty),
            SslMode = Enum.Parse<MySqlSslMode>(GetEnv("DB_SSL_MODE", "Disabled"), true)
        };

        return builder.ConnectionString;
    }

    private static string GetEnv(string key, string defaultValue)
    {
        return Environment.GetEnvironmentVariable(key) ?? defaultValue;
    }
}
