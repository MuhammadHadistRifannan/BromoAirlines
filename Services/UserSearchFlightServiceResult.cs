using BromoAirlines.Models;

namespace BromoAirlines.Services;

public sealed class UserSearchFlightServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;
    public List<JadwalPenerbanganView> Data { get; init; } = new();

    public static UserSearchFlightServiceResult Success(List<JadwalPenerbanganView> data)
    {
        return new UserSearchFlightServiceResult { IsSuccess = true, Data = data };
    }

    public static UserSearchFlightServiceResult Failed(string message)
    {
        return new UserSearchFlightServiceResult { IsSuccess = false, Message = message };
    }
}
