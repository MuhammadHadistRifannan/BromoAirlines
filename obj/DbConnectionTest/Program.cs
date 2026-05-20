using MySql.Data.MySqlClient;

var connectionString = "Server=localhost;Port=3306;Database=BromoAirlines;Uid=root;Pwd=;SslMode=Disabled;";

try
{
    using var connection = new MySqlConnection(connectionString);
    connection.Open();

    using var command = new MySqlCommand("SELECT DATABASE(), VERSION();", connection);
    using var reader = command.ExecuteReader();

    if (reader.Read())
    {
        Console.WriteLine($"DATABASE={reader.GetString(0)}");
        Console.WriteLine($"VERSION={reader.GetString(1)}");
    }

    Console.WriteLine("STATUS=OK");
}
catch (Exception ex)
{
    Console.WriteLine("STATUS=FAILED");
    Console.WriteLine(ex.GetType().FullName);
    Console.WriteLine(ex.Message);
}
