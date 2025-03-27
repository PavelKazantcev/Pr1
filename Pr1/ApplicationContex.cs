using Microsoft.EntityFrameworkCore;

namespace Pr1
{
    internal class ApplicationContex: DbContext
    {
        public DbSet<User> Users { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1111");
        }
    }
}
