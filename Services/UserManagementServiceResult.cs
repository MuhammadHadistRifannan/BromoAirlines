namespace BromoAirlines.Services;

public sealed class UserManagementServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static UserManagementServiceResult Success(string message)
    {
        return new UserManagementServiceResult { IsSuccess = true, Message = message };
    }

    public static UserManagementServiceResult Failed(string message)
    {
        return new UserManagementServiceResult { IsSuccess = false, Message = message };
    }
}
