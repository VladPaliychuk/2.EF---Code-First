using System.ComponentModel.DataAnnotations;

namespace EF.Hospital.DAL.Enteties
{
    public class Visitation
    {
        public Guid VisitationId { get; set; }
        public DateTime Date { get; set; }
        public string? Comments { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
