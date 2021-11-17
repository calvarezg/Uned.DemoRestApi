using DemoMediacion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoMediacion.Data.Configurations
{
    public class GuitarConfiguration : IEntityTypeConfiguration<Guitar>
    {
        public void Configure(EntityTypeBuilder<Guitar> builder)
        {
            builder.Property(g => g.Name).HasMaxLength(50).IsRequired();
        }
    }
}
