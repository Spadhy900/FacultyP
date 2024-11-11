using CustomAuth.Entities;
using Microsoft.EntityFrameworkCore;

namespace FacultyP.Entities
{
    public class AppdbContext : DbContext
    {
    public AppdbContext(DbContextOptions<AppdbContext> options): base(options) 
        { 

        }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
