namespace BromoAirlines.Models;

public sealed class PassengerInputData
{
    public string NamaLengkap { get; set; } = string.Empty;
    public string NomorIdentitas { get; set; } = string.Empty;
    public string JenisKelamin { get; set; } = string.Empty;
    public DateTime TanggalLahir { get; set; }
    public string Kewarganegaraan { get; set; } = string.Empty;
}
