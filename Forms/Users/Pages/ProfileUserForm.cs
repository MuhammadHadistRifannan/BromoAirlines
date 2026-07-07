using BromoAirlines.Models;
using BromoAirlines.Services;

namespace BromoAirlines.Forms.Users.Pages;

public partial class ProfileUserForm : Form
{
    private readonly int _akunId;
    private readonly UserProfileService _profileService;
    private bool _isEditMode;
    private bool _isPasswordMode;

    public ProfileUserForm(UserProfileService profileService, int akunId)
    {
        _profileService = profileService;
        _akunId = akunId;
        InitializeComponent();
        SetEditMode(false);
        SetPasswordMode(false);
        Load += ProfileUserFormLoad;
        Resize += ProfileUserFormResize;
    }

    private async void ProfileUserFormLoad(object? sender, EventArgs e)
    {
        AdjustLayout();
        await LoadProfileAsync();
    }

    private void BtnEditProfileClick(object sender, EventArgs e)
    {
        SetEditMode(true);
        lblStatus.Text = "Mode edit profile aktif.";
        lblStatus.ForeColor = Color.RoyalBlue;
    }

    private async void BtnSimpanClick(object sender, EventArgs e)
    {
        await SaveChangesAsync();
    }

    private async void BtnResetClick(object sender, EventArgs e)
    {
        SetEditMode(false);
        SetPasswordMode(false);
        ClearPasswordFields();
        await LoadProfileAsync();
    }

    private void BtnGantiPasswordClick(object sender, EventArgs e)
    {
        SetPasswordMode(true);
        lblStatus.Text = "Mode ganti password aktif.";
        lblStatus.ForeColor = Color.RoyalBlue;
    }

    private void ProfileUserFormResize(object? sender, EventArgs e)
    {
        AdjustLayout();
    }

    private async Task LoadProfileAsync()
    {
        try
        {
            var akun = await _profileService.GetProfileAsync(_akunId);
            ShowProfile(akun);
        }
        catch
        {
            ShowStatus("Profile belum dapat dimuat. Periksa koneksi database.", Color.Firebrick);
        }
    }

    private async Task SaveChangesAsync()
    {
        if (!_isEditMode && !_isPasswordMode)
        {
            ShowStatus("Pilih Edit Profile atau Ganti Password terlebih dahulu.", Color.DimGray);
            return;
        }

        if (_isEditMode && !await SaveProfileAsync())
        {
            return;
        }

        if (_isPasswordMode && !await SavePasswordAsync())
        {
            return;
        }

        SetEditMode(false);
        SetPasswordMode(false);
        ClearPasswordFields();
        await LoadProfileAsync();
    }

    private async Task<bool> SaveProfileAsync()
    {
        var result = await _profileService.UpdateProfileAsync(
            _akunId,
            txtNama.Text,
            txtUsername.Text,
            txtEmail.Text);
        ShowResult(result);
        return result.IsSuccess;
    }

    private async Task<bool> SavePasswordAsync()
    {
        var result = await _profileService.ChangePasswordAsync(
            _akunId,
            txtPasswordLama.Text,
            txtPasswordBaru.Text,
            txtKonfirmasiPassword.Text);
        ShowResult(result);
        return result.IsSuccess;
    }

    private void ShowProfile(Akun? akun)
    {
        if (akun is null)
        {
            ShowStatus("Data profile tidak ditemukan.", Color.Firebrick);
            return;
        }

        txtNama.Text = akun.Nama;
        txtUsername.Text = akun.Username;
        txtEmail.Text = GetDisplayEmail(akun);
        ShowStatus("Profile berhasil dimuat dari database.", Color.SeaGreen);
    }

    private void SetEditMode(bool enabled)
    {
        _isEditMode = enabled;
        txtNama.ReadOnly = !enabled;
        txtUsername.ReadOnly = !enabled;
        txtEmail.ReadOnly = !enabled;
    }

    private void SetPasswordMode(bool enabled)
    {
        _isPasswordMode = enabled;
        txtPasswordLama.ReadOnly = !enabled;
        txtPasswordBaru.ReadOnly = !enabled;
        txtKonfirmasiPassword.ReadOnly = !enabled;
    }

    private void ClearPasswordFields()
    {
        txtPasswordLama.Clear();
        txtPasswordBaru.Clear();
        txtKonfirmasiPassword.Clear();
    }

    private void ShowResult(UserProfileServiceResult result)
    {
        ShowStatus(result.Message, result.IsSuccess ? Color.SeaGreen : Color.Firebrick);
    }

    private void ShowStatus(string message, Color color)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = color;
    }

    private void AdjustLayout()
    {
        var contentWidth = Math.Max(720, panelContent.ClientSize.Width - 96);
        panelSummary.Width = contentWidth;
        panelProfile.Width = contentWidth;
        panelPassword.Width = contentWidth;
        btnReset.Left = 48 + contentWidth - btnReset.Width;
        btnSimpan.Left = btnReset.Left - btnSimpan.Width - 18;
        lblStatus.Width = Math.Max(320, contentWidth);
    }

    private static string GetDisplayEmail(Akun akun)
    {
        return akun.Email.Contains('@', StringComparison.Ordinal)
            ? akun.Email
            : $"{akun.Username}@bromoairlines.test";
    }
}
