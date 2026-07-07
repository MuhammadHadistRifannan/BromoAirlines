namespace BromoAirlines.Services;

public sealed class StatusPenerbanganServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static StatusPenerbanganServiceResult Success(string message)
    {
        return new StatusPenerbanganServiceResult { IsSuccess = true, Message = message };
    }

    public static StatusPenerbanganServiceResult Failed(string message)
    {
        return new StatusPenerbanganServiceResult { IsSuccess = false, Message = message };
    }
}
