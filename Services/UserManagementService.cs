using BromoAirlines.Models;
using BromoAirlines.Repositories;
using MySql.Data.MySqlClient;

namespace BromoAirlines.Services;

public sealed class UserManagementService
{
    private readonly AkunRepository _akunRepository;

    public UserManagementService(AkunRepository akunRepository)
    {
        _akunRepository = akunRepository;
    }

    public async Task<List<Akun>> SearchAsync(string keyword)
    {
        return await _akunRepository.SearchAsync(keyword.Trim());
    }

    public async Task<UserManagementServiceResult> AddAsync(Akun akun)
    {
        var validation = await ValidateAsync(akun, 0);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _akunRepository.InsertAsync(Normalize(akun));
        return UserManagementServiceResult.Success("User berhasil ditambahkan.");
    }

    public async Task<UserManagementServiceResult> UpdateAsync(Akun akun)
    {
        if (akun.ID <= 0)
        {
            return UserManagementServiceResult.Failed("Pilih user yang akan diedit.");
        }

        var validation = await ValidateAsync(akun, akun.ID);
        if (!validation.IsSuccess)
        {
            return validation;
        }

        await _akunRepository.UpdateAsync(Normalize(akun));
        return UserManagementServiceResult.Success("User berhasil diperbarui.");
    }

    public async Task<UserManagementServiceResult> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return UserManagementServiceResult.Failed("Pilih user yang akan dihapus.");
        }

        try
        {
            await _akunRepository.DeleteAsync(id);
            return UserManagementServiceResult.Success("User berhasil dihapus.");
        }
        catch (MySqlException)
        {
            return UserManagementServiceResult.Failed("User tidak dapat dihapus karena masih memiliki transaksi.");
        }
    }

    private async Task<UserManagementServiceResult> ValidateAsync(Akun akun, int ignoredId)
    {
        if (string.IsNullOrWhiteSpace(akun.Username) || string.IsNullOrWhiteSpace(akun.Password))
        {
            return UserManagementServiceResult.Failed("Username dan password wajib diisi.");
        }

        if (string.IsNullOrWhiteSpace(akun.Nama) || string.IsNullOrWhiteSpace(akun.NomorTelepon))
        {
            return UserManagementServiceResult.Failed("Nama dan nomor telepon wajib diisi.");
        }

        if (akun.TanggalLahir.Date > DateTime.Today)
        {
            return UserManagementServiceResult.Failed("Tanggal lahir tidak boleh di masa depan.");
        }

        return await ValidateUniqueUsernameAsync(akun.Username, ignoredId);
    }

    private async Task<UserManagementServiceResult> ValidateUniqueUsernameAsync(string username, int ignoredId)
    {
        var isExists = await _akunRepository.IsUsernameExistsAsync(username.Trim(), ignoredId);
        return isExists
            ? UserManagementServiceResult.Failed("Username sudah digunakan.")
            : UserManagementServiceResult.Success(string.Empty);
    }

    private static Akun Normalize(Akun akun)
    {
        return new Akun
        {
            ID = akun.ID,
            Username = akun.Username.Trim(),
            Password = akun.Password.Trim(),
            Nama = akun.Nama.Trim(),
            TanggalLahir = akun.TanggalLahir.Date,
            NomorTelepon = akun.NomorTelepon.Trim(),
            MerupakanAdmin = akun.MerupakanAdmin
        };
    }
}
