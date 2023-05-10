﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Enteties
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public bool HasInsurance { get; set; }
        public ICollection<Diagnose>? Diagnoses { get; set; }
        public ICollection<PatientMedicament>? Prescriptions { get; set; }
        public ICollection<Visitation>? Visitations { get; set; }
    }
}
