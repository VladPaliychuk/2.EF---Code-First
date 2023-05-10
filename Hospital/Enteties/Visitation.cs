using System.ComponentModel.DataAnnotations;

namespace EF.Hospital.DAL.Enteties
{
    public class Visitation
    {
        public int VisitationID { get; set; }
        public string? Comments { get; set; }
        public DateTime? Date { get; set; }
        public int PatientId { get; set; }
        public Patient? Patients { get; set; }
    }
}
