using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Enteties
{
    public class PatientMedicament
    {
        public int PatientID { get; set; }
        public Patient? Patient { get; set; }

        public int MedicamentID { get; set; }
        public Medicament? Medicament { get; set; }
    }
}
