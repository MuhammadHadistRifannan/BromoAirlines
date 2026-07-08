using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class AuthService
{
    private readonly AkunRepository _akunRepository = new();

    public AuthServiceResult Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return AuthServiceResult.Failed("Username dan password wajib diisi.");
        }

        try
        {
            var akun = _akunRepository.FindByUsernameAndPassword(username.Trim(), password.Trim());
            return akun is null
                ? AuthServiceResult.Failed("Username atau password tidak valid.")
                : AuthServiceResult.Success("Login berhasil.", akun);
        }
        catch
        {
            return AuthServiceResult.Failed("Login belum dapat diproses. Periksa koneksi database.");
        }
    }

    public async Task<AuthServiceResult> RegisterAsync(
        string nama,
        string username,
        string password,
        string konfirmasiPassword,
        DateTime tanggalLahir,
        string nomorTelepon)
    {
        var validation = await ValidateRegisterAsync(
            nama,
            username,
            password,
            konfirmasiPassword,
            tanggalLahir,
            nomorTelepon);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        try
        {
            await _akunRepository.InsertAsync(CreateUser(
                nama,
                username,
                password,
                tanggalLahir,
                nomorTelepon));
            return AuthServiceResult.Success("Registrasi berhasil. Silakan login.");
        }
        catch
        {
            return AuthServiceResult.Failed("Registrasi belum dapat diproses. Periksa koneksi database.");
        }
    }

    private async Task<AuthServiceResult> ValidateRegisterAsync(
        string nama,
        string username,
        string password,
        string konfirmasiPassword,
        DateTime tanggalLahir,
        string nomorTelepon)
    {
        if (HasEmptyRegisterField(nama, username, password, nomorTelepon))
        {
            return AuthServiceResult.Failed("Nama, username, password, dan telepon wajib diisi.");
        }

        if (password.Trim().Length < 6)
        {
            return AuthServiceResult.Failed("Password minimal 6 karakter.");
        }

        if (password != konfirmasiPassword)
        {
            return AuthServiceResult.Failed("Konfirmasi password tidak sama.");
        }

        if (tanggalLahir.Date > DateTime.Today)
        {
            return AuthServiceResult.Failed("Tanggal lahir tidak boleh di masa depan.");
        }

        return await ValidateUsernameAsync(username);
    }

    private async Task<AuthServiceResult> ValidateUsernameAsync(string username)
    {
        try
        {
            var exists = await _akunRepository.IsUsernameExistsAsync(username.Trim(), 0);
            return exists
                ? AuthServiceResult.Failed("Username sudah digunakan.")
                : AuthServiceResult.Success(string.Empty);
        }
        catch
        {
            return AuthServiceResult.Failed("Validasi username belum dapat diproses.");
        }
    }

    private static bool HasEmptyRegisterField(
        string nama,
        string username,
        string password,
        string nomorTelepon)
    {
        return string.IsNullOrWhiteSpace(nama)
            || string.IsNullOrWhiteSpace(username)
            || string.IsNullOrWhiteSpace(password)
            || string.IsNullOrWhiteSpace(nomorTelepon);
    }

    private static Akun CreateUser(
        string nama,
        string username,
        string password,
        DateTime tanggalLahir,
        string nomorTelepon)
    {
        return new Akun
        {
            Nama = nama.Trim(),
            Username = username.Trim(),
            Password = password.Trim(),
            TanggalLahir = tanggalLahir.Date,
            NomorTelepon = nomorTelepon.Trim(),
            MerupakanAdmin = 0
        };
    }
}
