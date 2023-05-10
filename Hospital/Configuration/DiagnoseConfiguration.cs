using EF.Hospital.DAL.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Hospital.DAL.Configuration
{
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.Property(diagnoses => diagnoses.DiagnoseID)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(diagnoses => diagnoses.Name)
                   .HasMaxLength(50)
                   .IsUnicode(true);
            builder.Property(diagnoses => diagnoses.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);
            builder.HasOne(diagnoses => diagnoses.Patients)
               .WithMany(patients => patients.Diagnoses)
               .HasForeignKey(patients => patients.PatientId);
        }
    }
}
