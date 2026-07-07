namespace BromoAirlines.Services;

public sealed class UserTransactionServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;
    public int TransaksiHeaderId { get; init; }

    public static UserTransactionServiceResult Success(string message, int transaksiHeaderId)
    {
        return new UserTransactionServiceResult
        {
            IsSuccess = true,
            Message = message,
            TransaksiHeaderId = transaksiHeaderId
        };
    }

    public static UserTransactionServiceResult Failed(string message)
    {
        return new UserTransactionServiceResult { IsSuccess = false, Message = message };
    }
}
