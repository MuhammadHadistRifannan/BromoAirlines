namespace BromoAirlines.Services;

public sealed class JadwalPenerbanganServiceResult
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;

    public static JadwalPenerbanganServiceResult Success(string message)
    {
        return new JadwalPenerbanganServiceResult { IsSuccess = true, Message = message };
    }

    public static JadwalPenerbanganServiceResult Failed(string message)
    {
        return new JadwalPenerbanganServiceResult { IsSuccess = false, Message = message };
    }
}
