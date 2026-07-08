using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class BookingForm : Form
{
    private readonly UserBookingService _bookingService;
    private readonly JadwalPenerbanganView _flight;
    private readonly Maskapai _maskapai;

    public BookingForm(UserBookingService bookingService, JadwalPenerbanganView flight, Maskapai maskapai)
    {
        _bookingService = bookingService;
        _flight = flight;
        _maskapai = maskapai;
        InitializeComponent();
        Load += BookingFormLoad;

    }

    public event EventHandler<PassengerRequestedEventArgs>? PassengerRequested;

    private void BtnLanjutClick(object sender, EventArgs e)
    {
        PassengerRequested?.Invoke(
            this,
            new PassengerRequestedEventArgs(
                _flight,
                (int)numJumlahPenumpang.Value,
                cmbPromo.SelectedItem as KodePromo));
    }

    private async void BookingFormLoad(object? sender, EventArgs e)
    {
        txtJadwal.Text = $"{_flight.KodePenerbangan} | {_flight.BandaraKeberangkatan} -> {_flight.BandaraTujuan} | {_flight.TanggalWaktuKeberangkatan:dd/MM/yyyy HH:mm}";
        await LoadPromosAsync();
    }

    private async Task LoadPromosAsync()
    {
        try
        {
            var promos = await _bookingService.GetActivePromosAsync(GetSelectedMaskapaiId());
            cmbPromo.DataSource = null;
            cmbPromo.DisplayMember = nameof(KodePromo.Kode);
            cmbPromo.ValueMember = nameof(KodePromo.ID);
            cmbPromo.DataSource = promos;
            cmbPromo.SelectedIndex = -1;
            lblPromoHint.Text = promos.Count == 0
                ? "Tidak ada promo aktif untuk maskapai penerbangan ini."
                : "Promo bersifat opsional dan akan dihitung pada tahap pembayaran.";
        }
        catch
        {
            MessageBox.Show(
                "Data promo belum dapat dimuat. Periksa koneksi database.",
                "BromoAirlines",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private int GetSelectedMaskapaiId()
    {
        return _maskapai.ID > 0 ? _maskapai.ID : _flight.MaskapaiID;
    }
}
