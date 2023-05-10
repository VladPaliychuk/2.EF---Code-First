using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDAL.Data.Entities;
using SalesDAL.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDAL.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CreditCardNumber);

            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            new CustomerSeeder().Seed(builder);
        }
    }
}
