namespace BromoAirlines.Services;

public sealed class TransaksiServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static TransaksiServiceResult Success(string message)
    {
        return new TransaksiServiceResult { IsSuccess = true, Message = message };
    }

    public static TransaksiServiceResult Failed(string message)
    {
        return new TransaksiServiceResult { IsSuccess = false, Message = message };
    }
}
