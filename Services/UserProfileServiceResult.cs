namespace BromoAirlines.Services;

public sealed class UserProfileServiceResult
{
    private UserProfileServiceResult(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    public bool IsSuccess { get; }
    public string Message { get; }

    public static UserProfileServiceResult Success(string message)
    {
        return new UserProfileServiceResult(true, message);
    }

    public static UserProfileServiceResult Failed(string message)
    {
        return new UserProfileServiceResult(false, message);
    }
}
