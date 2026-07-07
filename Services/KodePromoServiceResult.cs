namespace BromoAirlines.Services;

public sealed class KodePromoServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static KodePromoServiceResult Success(string message)
    {
        return new KodePromoServiceResult { IsSuccess = true, Message = message };
    }

    public static KodePromoServiceResult Failed(string message)
    {
        return new KodePromoServiceResult { IsSuccess = false, Message = message };
    }
}
