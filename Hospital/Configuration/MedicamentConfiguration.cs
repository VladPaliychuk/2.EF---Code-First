using EF.Hospital.DAL.Enteties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Configuration
{
    public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(m => m.MedicamentID);

            builder.Property(m => m.Name)
                .HasMaxLength(50)
                .IsUnicode(true);
        }
    }
}
