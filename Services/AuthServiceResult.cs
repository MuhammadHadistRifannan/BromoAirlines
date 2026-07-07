using BromoAirlines.Models;

namespace BromoAirlines.Services;

public sealed class AuthServiceResult
{
    private AuthServiceResult(bool isSuccess, string message, Akun? akun)
    {
        IsSuccess = isSuccess;
        Message = message;
        Akun = akun;
    }

    public bool IsSuccess { get; }
    public string Message { get; }
    public Akun? Akun { get; }

    public static AuthServiceResult Success(string message, Akun? akun = null)
    {
        return new AuthServiceResult(true, message, akun);
    }

    public static AuthServiceResult Failed(string message)
    {
        return new AuthServiceResult(false, message, null);
    }
}
