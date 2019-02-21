using OnBoarding.Contract.Repository;
using MediatR;
using OnBoarding.Contract.Health;
using System.Linq;

namespace OnBoarding.Data
{
    public class ValidateHealth: IRequestHandler<HealthValidateRequest, Health>
    {
        private readonly IRepository repository;
        public ValidateHealth(IRepository repository)
        {
            this.repository = repository;
        }

        public Health Handle(HealthValidateRequest query)
        {
            var health = this.repository.Query<Entities.Health>().Where(i => i.MobileNumber == query.MobileNumber && i.PatientName == query.PatientName).FirstOrDefault();
            if (health == null)
            {
                return new Health
                {
                    MobileNumber = 0,
                    HospitalName = "Not Available"
                };
            }
            return new Health
            {
                MobileNumber = health.MobileNumber,
                HospitalName = health.HospitalName,
                PatientName = health.PatientName,
                DateOfBirth = health.DateOfBirth,
                Smoker = health.Smoker,
                KnownDisease = health.KnownDisease,
                TreatmentDate = health.TreatmentDate
            };
        }
    }
}
