using BromoAirlines.Models;
using BromoAirlines.Repositories;

namespace BromoAirlines.Services;

public sealed class UserProfileService
{
    private readonly AkunRepository _akunRepository;

    public UserProfileService(AkunRepository akunRepository)
    {
        _akunRepository = akunRepository;
    }

    public async Task<Akun?> GetProfileAsync(int akunId)
    {
        return await _akunRepository.FindByIdAsync(akunId);
    }

    public async Task<UserProfileServiceResult> UpdateProfileAsync(
        int akunId,
        string nama,
        string username,
        string email)
    {
        var validation = await ValidateProfileAsync(akunId, nama, username, email);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _akunRepository.UpdateProfileAsync(CreateProfile(akunId, nama, username, email));
        return UserProfileServiceResult.Success("Profile berhasil diperbarui.");
    }

    public async Task<UserProfileServiceResult> ChangePasswordAsync(
        int akunId,
        string passwordLama,
        string passwordBaru,
        string konfirmasiPassword)
    {
        var akun = await _akunRepository.FindByIdAsync(akunId);
        var validation = ValidatePassword(akun, passwordLama, passwordBaru, konfirmasiPassword);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _akunRepository.UpdatePasswordAsync(akunId, passwordBaru.Trim());
        return UserProfileServiceResult.Success("Password berhasil diperbarui.");
    }

    private async Task<UserProfileServiceResult> ValidateProfileAsync(
        int akunId,
        string nama,
        string username,
        string email)
    {
        if (akunId <= 0)
        {
            return UserProfileServiceResult.Failed("Akun user tidak valid.");
        }

        if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username))
        {
            return UserProfileServiceResult.Failed("Nama dan username wajib diisi.");
        }

        if (!IsValidEmail(email))
        {
            return UserProfileServiceResult.Failed("Email wajib diisi dengan format yang benar.");
        }

        return await ValidateUniqueUsernameAsync(username, akunId);
    }

    private async Task<UserProfileServiceResult> ValidateUniqueUsernameAsync(string username, int akunId)
    {
        var isExists = await _akunRepository.IsUsernameExistsAsync(username.Trim(), akunId);
        return isExists
            ? UserProfileServiceResult.Failed("Username sudah digunakan.")
            : UserProfileServiceResult.Success(string.Empty);
    }

    private static UserProfileServiceResult ValidatePassword(
        Akun? akun,
        string passwordLama,
        string passwordBaru,
        string konfirmasiPassword)
    {
        if (akun is null)
        {
            return UserProfileServiceResult.Failed("Data akun tidak ditemukan.");
        }

        if (akun.Password != passwordLama)
        {
            return UserProfileServiceResult.Failed("Password lama tidak sesuai.");
        }

        return ValidateNewPassword(passwordBaru, konfirmasiPassword);
    }

    private static UserProfileServiceResult ValidateNewPassword(string passwordBaru, string konfirmasiPassword)
    {
        if (string.IsNullOrWhiteSpace(passwordBaru) || passwordBaru.Trim().Length < 6)
        {
            return UserProfileServiceResult.Failed("Password baru minimal 6 karakter.");
        }

        return passwordBaru == konfirmasiPassword
            ? UserProfileServiceResult.Success(string.Empty)
            : UserProfileServiceResult.Failed("Konfirmasi password tidak sama.");
    }

    private static Akun CreateProfile(int akunId, string nama, string username, string email)
    {
        return new Akun
        {
            ID = akunId,
            Nama = nama.Trim(),
            Username = username.Trim(),
            Email = email.Trim()
        };
    }

    private static bool IsValidEmail(string email)
    {
        return !string.IsNullOrWhiteSpace(email)
            && email.Contains('@', StringComparison.Ordinal)
            && email.Contains('.', StringComparison.Ordinal);
    }
}
