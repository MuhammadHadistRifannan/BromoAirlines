namespace BromoAirlines.Services;

public sealed class BandaraServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static BandaraServiceResult Success(string message)
    {
        return new BandaraServiceResult { IsSuccess = true, Message = message };
    }

    public static BandaraServiceResult Failed(string message)
    {
        return new BandaraServiceResult { IsSuccess = false, Message = message };
    }
}
