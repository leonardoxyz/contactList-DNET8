using blazorServerDNET.Models;
using Microsoft.EntityFrameworkCore;

namespace blazorServerDNET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
