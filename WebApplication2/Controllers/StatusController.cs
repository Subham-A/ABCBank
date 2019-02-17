using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    //[RoutePrefix("promotions")]
    public class StatusController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(100);
        }
    }
}
