using Microsoft.EntityFrameworkCore;

namespace Pr1
{
    internal class ApplicationContex: DbContext
    {
        public DbSet<User> Users { get; set; } = null;

        public ApplicationContex()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=1111");
        }
    }
}
