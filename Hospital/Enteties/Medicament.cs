using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Enteties
{
    public class Medicament
    {
        public int MedicamentID { get; set; }
        public string? Name { get; set; }
        public ICollection<PatientMedicament>? Prescriptions { get; set; }
    }
}
