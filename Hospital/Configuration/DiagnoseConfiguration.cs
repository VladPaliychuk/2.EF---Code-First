using EF.Hospital.DAL.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Hospital.DAL.Configuration
{
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.HasKey(diagnose => diagnose.DiagnoseId);

            builder.Property(diagnose => diagnose.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(diagnose => diagnose.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(diagnose => diagnose.Patient)
                .WithMany(patient => patient.Diagnoses)
                .HasForeignKey(diagnose => diagnose.PatientId);
        }
    }
}
