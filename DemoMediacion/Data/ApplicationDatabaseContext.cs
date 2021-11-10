using DemoMediacion.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMediacion.Data
{
    public class ApplicationDatabaseContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        public ApplicationDatabaseContext(DbContextOptions options) : base(options)
        { }
    }
}
