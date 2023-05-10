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
    public class VisitationConfiguration : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder.HasKey(visitations => visitations.VisitationId);

            builder.Property(visitations => visitations.Date);

            builder.Property(visitations => visitations.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(visitations => visitations.Patient)
                .WithMany(patients => patients.Visitations)
                .HasForeignKey(visitations => visitations.PatientId);

            //builder.HasOne(visitations => visitations.Doctor)
            //   .WithMany(doctors => doctors.Visitations)
            //   .HasForeignKey(visitations => visitations.DoctorId);
        }
    }
}
