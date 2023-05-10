using System.ComponentModel.DataAnnotations;

namespace EF.Hospital.DAL.Enteties
{
    public class Visitation
    {
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        public string? Comments { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
