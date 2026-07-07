using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public partial class PassengerForm : Form
{
    private readonly JadwalPenerbanganView? _flight;
    private readonly KodePromo? _promo;
    private readonly int _passengerCount;

    public PassengerForm()
        : this(null, 1, null)
    {
    }

    public PassengerForm(JadwalPenerbanganView? flight, int passengerCount, KodePromo? promo)
    {
        _flight = flight;
        _promo = promo;
        _passengerCount = Math.Max(1, passengerCount);
        InitializeComponent();
        Load += PassengerFormLoad;
        Resize += PassengerFormResize;
    }

    public event EventHandler<PaymentRequestedEventArgs>? PaymentRequested;

    private void PassengerFormLoad(object? sender, EventArgs e)
    {
        if (_flight != null)
        {
            lblSummaryDescription.Text = $"{_flight.KodePenerbangan} | {_flight.BandaraKeberangkatan} -> {_flight.BandaraTujuan} | {_passengerCount} penumpang";
        }

        LoadPassengerInputs();
    }

    private void BtnLanjutClick(object sender, EventArgs e)
    {
        if (_flight == null)
        {
            MessageBox.Show(
                "Jadwal penerbangan belum tersedia.",
                "BromoAirlines",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        PaymentRequested?.Invoke(this, new PaymentRequestedEventArgs(CreateBookingContext()));
    }

    private void PassengerFormResize(object? sender, EventArgs e)
    {
        AdjustLayout();
    }

    private void LoadPassengerInputs()
    {
        flowPassenger.Controls.Clear();

        for (var index = 1; index <= _passengerCount; index++)
        {
            flowPassenger.Controls.Add(CreatePassengerInput(index));
        }
    }

    private void AdjustLayout()
    {
        var actionTop = Math.Max(panelSummary.Bottom + 240, ClientSize.Height - panelAction.Height - 24);
        panelAction.Top = actionTop;
        panelAction.Width = ClientSize.Width - (panelAction.Left * 2);

        flowPassenger.Height = Math.Max(220, panelAction.Top - flowPassenger.Top - 24);
        flowPassenger.Width = ClientSize.Width - (flowPassenger.Left * 2);
        btnLanjut.Left = panelAction.Width - btnLanjut.Width;
    }

    private UserBookingContext CreateBookingContext()
    {
        return new UserBookingContext
        {
            Flight = _flight!,
            JumlahPenumpang = _passengerCount,
            Promo = _promo,
            Passengers = GetPassengerInputs()
        };
    }

    private List<PassengerInputData> GetPassengerInputs()
    {
        return flowPassenger.Controls
            .OfType<PassengerInputControl>()
            .Select(control => control.GetPassengerData())
            .ToList();
    }

    private static PassengerInputControl CreatePassengerInput(int passengerNumber)
    {
        var control = new PassengerInputControl
        {
            Margin = new Padding(0, 0, 0, 18)
        };

        control.SetPassengerNumber(passengerNumber);
        return control;
    }
}
