using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public partial class FlightDetailForm : Form
{
    private readonly JadwalPenerbanganView _flight;
    private readonly Maskapai _maskapai;

    public FlightDetailForm(JadwalPenerbanganView flight, Maskapai maskapai)
    {
        _flight = flight;
        _maskapai = maskapai;
        InitializeComponent();
        Load += FlightDetailFormLoad;
    }

    public event EventHandler<BookingRequestedEventArgs>? BookingRequested;

    private void BtnBookingClick(object sender, EventArgs e)
    {
        BookingRequested?.Invoke(this, new BookingRequestedEventArgs(_flight, _maskapai));
    }

    private void FlightDetailFormLoad(object? sender, EventArgs e)
    {
        lblSummaryRoute.Text = $"{_flight.BandaraKeberangkatan} menuju {_flight.BandaraTujuan}";
        lblMaskapaiValue.Text = string.IsNullOrWhiteSpace(_maskapai.Nama) ? _flight.Maskapai : _maskapai.Nama;
        lblBandaraValue.Text = $"{_flight.BandaraKeberangkatan} -> {_flight.BandaraTujuan}";
        lblJadwalValue.Text = _flight.TanggalWaktuKeberangkatan.ToString("dd/MM/yyyy HH:mm");
        lblHargaValue.Text = $"Rp {_flight.HargaPerTiket:N0}";
        lblKursiTersediaValue.Text = "-";
    }
}
