﻿using System;

namespace OnBoarding.Contract.Health
{
    public class Health
    {
        public int MobileNumber { get; set; }

        public string HospitalName { get; set; }

        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Smoker { get; set; }

        public string KnownDisease { get; set; }

        public DateTime TreatmentDate { get; set; }
    }
}