﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Hospital.DAL.Enteties
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string? Specialty { get; set; }
        public ICollection<Visitation>? Visitations { get; set; }

    }
}
