using LoginApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginApplication.DbContexts
{
    public class LoginDbContext :DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>().HasIndex(u => u.Username).IsUnique();
        }

        public DbSet<UserLogin> Users { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
