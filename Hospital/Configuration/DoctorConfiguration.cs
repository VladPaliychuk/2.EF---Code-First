using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EF.Hospital.DAL.Enteties;

namespace EF.Hospital.DAL.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.DoctorId);

            builder.Property(d => d.Specialty)
                .HasMaxLength(100)
                .IsUnicode(true);
        }
    }
}
