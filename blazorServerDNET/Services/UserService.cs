using blazorServerDNET.Data;
using blazorServerDNET.Models;
using Microsoft.EntityFrameworkCore;

namespace blazorServerDNET.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var result = await _context.Users.ToListAsync();
            return result;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }

        public async Task UpdateUserAsync(User user, int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser != null)
            {
                dbUser.Name = user.Name;
                dbUser.Email = user.Email;
                dbUser.Phone = user.Phone;

                await _context.SaveChangesAsync();
            }
        }
    }
}
