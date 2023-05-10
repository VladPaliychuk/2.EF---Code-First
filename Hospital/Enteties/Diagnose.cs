using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Enteties
{
    public class Diagnose
    {
        public Guid DiagnoseId { get; set; }
        public string? Name { get; set; }
        public string? Comments { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
