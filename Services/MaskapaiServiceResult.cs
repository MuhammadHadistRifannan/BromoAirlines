namespace BromoAirlines.Services;

public sealed class MaskapaiServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static MaskapaiServiceResult Success(string message)
    {
        return new MaskapaiServiceResult { IsSuccess = true, Message = message };
    }

    public static MaskapaiServiceResult Failed(string message)
    {
        return new MaskapaiServiceResult { IsSuccess = false, Message = message };
    }
}
