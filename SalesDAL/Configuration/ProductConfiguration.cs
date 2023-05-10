using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDAL.Data.Entities;
using SalesDAL.Seeding;

namespace SalesDAL.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.Quantity);

            builder.Property(p => p.Price);

            builder.Property(p => p.Description)
               .HasMaxLength(250)
               .HasDefaultValue("No description");

            new ProductSeeder().Seed(builder);
        }
    }
}
