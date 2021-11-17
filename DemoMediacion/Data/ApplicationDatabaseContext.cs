using DemoMediacion.Data.Configurations;
using DemoMediacion.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMediacion.Data
{
    public class ApplicationDatabaseContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }

        public DbSet<GuitarHistory> GuitarLog { get; set; }

        public ApplicationDatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GuitarConfiguration());
        }
    }
}
