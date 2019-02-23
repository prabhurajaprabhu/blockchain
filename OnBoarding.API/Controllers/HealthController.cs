using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MediatR;
using OnBoarding.Contract.Health;

namespace OnBoardingWEB.Controllers
{
    [RoutePrefix("api/Health")]
    public class HealthController : ApiController
    {

        private readonly IMediator mediatr;
        public HealthController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }

        [HttpPost]
        [Route("getHealthDetail")]
        // GET: api/Health
        public Health GetHealthDetail(Health healthDetail)
        {
            var response = this.mediatr.Send(new HealthValidateRequest(healthDetail.MobileNumber, healthDetail.PatientName, healthDetail.TreatmentDate, healthDetail.DiseaseType));

            return response.Result;
        }
    }
}
