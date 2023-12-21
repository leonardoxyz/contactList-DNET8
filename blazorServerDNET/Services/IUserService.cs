using blazorServerDNET.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazorServerDNET.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id); 
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user, Guid id); 
        Task DeleteUserAsync(Guid id);
    }
}
