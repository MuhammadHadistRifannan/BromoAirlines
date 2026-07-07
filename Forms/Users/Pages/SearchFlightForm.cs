using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class SearchFlightForm : Form
{
    private readonly UserSearchFlightService _searchFlightService;
    private readonly List<JadwalPenerbanganView> _currentFlights = new();

    public SearchFlightForm(UserSearchFlightService searchFlightService)
    {
        _searchFlightService = searchFlightService;
        InitializeComponent();
        Load += SearchFlightFormLoad;
    }

    public event EventHandler<FlightSelectedEventArgs>? FlightDetailRequested;

    private async void SearchFlightFormLoad(object? sender, EventArgs e)
    {
        await LoadBandaraAsync();
        await LoadTopFlightsAsync();
    }

    private async void BtnResetClick(object sender, EventArgs e)
    {
        cmbBandaraAsal.SelectedIndex = -1;
        cmbBandaraTujuan.SelectedIndex = -1;
        dtpTanggalBerangkat.Value = DateTime.Today;
        numJumlahPenumpang.Value = 1;
        await LoadTopFlightsAsync();
    }

    private async void BtnSearchClick(object sender, EventArgs e)
    {
        await SearchFlightsAsync();
    }

    private void BtnDetailClick(object sender, EventArgs e)
    {
        RequestFlightDetail();
    }

    private void GridFlightCellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            RequestFlightDetail();
        }
    }

    private async Task LoadBandaraAsync()
    {
        try
        {
            var bandara = await _searchFlightService.GetBandaraAsync();
            BindBandara(cmbBandaraAsal, bandara);
            BindBandara(cmbBandaraTujuan, bandara);
        }
        catch
        {
            MessageBox.Show(
                "Data bandara belum dapat dimuat. Periksa koneksi database.",
                "BromoAirlines",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private async Task LoadTopFlightsAsync()
    {
        try
        {
            var jadwal = await _searchFlightService.GetTopFlightsAsync(10);
            BindFlights(jadwal);
        }
        catch
        {
            ShowFriendlyMessage("Jadwal penerbangan awal belum dapat dimuat. Periksa koneksi database.");
        }
    }

    private async Task SearchFlightsAsync()
    {
        try
        {
            var result = await _searchFlightService.SearchAsync(
                GetSelectedBandaraId(cmbBandaraAsal),
                GetSelectedBandaraId(cmbBandaraTujuan),
                dtpTanggalBerangkat.Value,
                (int)numJumlahPenumpang.Value);

            if (!result.IsSuccess)
            {
                ShowFriendlyMessage(result.Message);
                return;
            }

            BindFlights(result.Data);
        }
        catch
        {
            ShowFriendlyMessage("Pencarian penerbangan belum dapat dilakukan. Periksa koneksi database.");
        }
    }

    private static void BindBandara(ComboBox comboBox, List<BandaraView> bandara)
    {
        comboBox.DataSource = null;
        comboBox.DisplayMember = nameof(BandaraView.Nama);
        comboBox.ValueMember = nameof(BandaraView.ID);
        comboBox.DataSource = bandara.ToList();
        comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        comboBox.SelectedIndex = -1;
    }

    private void BindFlights(List<JadwalPenerbanganView> jadwal)
    {
        gridFlight.Rows.Clear();
        _currentFlights.Clear();
        _currentFlights.AddRange(jadwal);

        foreach (var item in jadwal)
        {
            gridFlight.Rows.Add(
                item.KodePenerbangan,
                item.Maskapai,
                item.BandaraKeberangkatan,
                item.BandaraTujuan,
                item.TanggalWaktuKeberangkatan.ToString("dd/MM/yyyy"),
                item.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                $"{item.DurasiPenerbangan} menit",
                item.HargaPerTiket.ToString("N0"),
                "-");
        }
    }

    private void RequestFlightDetail()
    {
        if (gridFlight.CurrentRow == null || gridFlight.CurrentRow.Index >= _currentFlights.Count)
        {
            ShowFriendlyMessage("Pilih jadwal penerbangan terlebih dahulu.");
            return;
        }

        FlightDetailRequested?.Invoke(
            this,
            new FlightSelectedEventArgs(_currentFlights[gridFlight.CurrentRow.Index]));
    }

    private static int GetSelectedBandaraId(ComboBox comboBox)
    {
        return comboBox.SelectedValue is int id ? id : 0;
    }

    private static void ShowFriendlyMessage(string message)
    {
        MessageBox.Show(
            message,
            "BromoAirlines",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
