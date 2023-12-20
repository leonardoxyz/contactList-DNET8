using blazorServerDNET.Models;

namespace blazorServerDNET.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync (User user);
        Task UpdateUserAsync (User user, int id);
        Task DeleteUserAsync (int id);
    }
}
