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

        [HttpGet]
        [Route("getHealthDetail/{mobileNumber}/{patientName}")]
        // GET: api/Health
        public Health GetHealthDetail(int mobileNumber, string patientName)
        {
            var response = this.mediatr.Send(new HealthValidateRequest(mobileNumber, patientName));

            return response.Result;
        }
    }
}
