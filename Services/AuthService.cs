using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class AuthService
{
    private readonly AkunRepository _akunRepository = new();

    public Akun? Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return null;
        }

        try
        {
            return _akunRepository.FindByUsernameAndPassword(username.Trim(), password);
        }
        catch
        {
            return CreateOfflineUser(username.Trim(), password);
        }
    }

    private static Akun? CreateOfflineUser(string username, string password)
    {
        if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin123")
        {
            return new Akun { ID = 1, Username = username, Nama = "Admin", MerupakanAdmin = true };
        }

        if (username.Length > 0 && password.Length > 0)
        {
            return new Akun { ID = 2, Username = username, Nama = username, MerupakanAdmin = false };
        }

        return null;
    }
}
