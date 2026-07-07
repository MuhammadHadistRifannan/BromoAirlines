using BromoAirlines.Models;

namespace BromoAirlines.Forms.Users.Pages;

public partial class PassengerInputControl : UserControl
{
    public PassengerInputControl()
    {
        InitializeComponent();
    }

    public void SetPassengerNumber(int passengerNumber)
    {
        lblPassengerTitle.Text = $"Penumpang {passengerNumber}";
    }

    public PassengerInputData GetPassengerData()
    {
        return new PassengerInputData
        {
            NamaLengkap = txtNamaLengkap.Text.Trim(),
            NomorIdentitas = txtNomorIdentitas.Text.Trim(),
            JenisKelamin = cmbJenisKelamin.Text.Trim(),
            TanggalLahir = dtpTanggalLahir.Value.Date,
            Kewarganegaraan = txtKewarganegaraan.Text.Trim()
        };
    }
}
