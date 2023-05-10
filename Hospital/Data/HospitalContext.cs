using EF.Hospital.DAL.Configuration;
using EF.Hospital.DAL.Enteties;
using Microsoft.EntityFrameworkCore;

namespace EF.Hospital.DAL.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Visitation> Visitations => Set<Visitation>();
        public DbSet<Diagnose> Diagnose => Set<Diagnose>();
        public DbSet<Medicament> Medicaments => Set<Medicament>();
        public DbSet<PatientMedicament> Prescriptions => Set<PatientMedicament>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DiagnoseConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientMedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new VisitationConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=Hospital;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=True;");
            }
        }
    }
}
