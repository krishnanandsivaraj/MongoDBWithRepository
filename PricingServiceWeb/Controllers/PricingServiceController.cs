using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PricingServiceWeb.Data;
using PricingServiceWeb.Models;

namespace PricingServiceWeb.Controllers
{
    [RoutePrefix("PricingService")]
    public class PricingServiceController : ApiController
    {
        public IProductOperation _repository = null;
        
        public PricingServiceController()
        {
            _repository = new ProductOperation();
        }
        [Route("Price")]
        [AcceptVerbs("POST", "PUT")]
        public void Put([FromBody]PriceList value)
        {
            _repository.Update(value);
        }

    }
}
