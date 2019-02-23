using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBoarding.Contract.Health;
using MediatR;

namespace OnBoarding.Contract.Health
{
    public class HealthValidateRequest: IRequest<Health>
    {
        public HealthValidateRequest(int mobileNumber, string patientName, DateTime policyStartDate, string diseaseType)
        {
            MobileNumber = mobileNumber;

            PatientName = patientName;

            PolicyStartDate = policyStartDate;

            DiseaseType = diseaseType;
        }
        public int MobileNumber { get; set; }

        public string PatientName { get; set; }

        public DateTime PolicyStartDate { get; set; }

        public string DiseaseType { get; set; }
    }
}
