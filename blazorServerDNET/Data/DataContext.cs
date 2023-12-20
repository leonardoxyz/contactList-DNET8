using blazorServerDNET.Models;
using Microsoft.EntityFrameworkCore;

namespace blazorServerDNET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Leo", Email = "leo@gmail.com", Phone = "(16) 99125-0029" }
                );
        }

        public DbSet<User> Users { get; set; }
    }
}
