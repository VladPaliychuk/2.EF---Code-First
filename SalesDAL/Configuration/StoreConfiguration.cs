using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SalesDAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesDAL.Seeding;

namespace SalesDAL.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(st => st.StoreId);

            builder.Property(st => st.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            new StoreSeeder().Seed(builder);
        }
    }
}
