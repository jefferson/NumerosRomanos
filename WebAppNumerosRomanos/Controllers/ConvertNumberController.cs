using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppNumerosRomanos.Controllers
{
    public class ConvertNumberController : ApiController
    {
        // GET api/values/5
        public string Get(int number)
        {
            return "value";
        }
    }
}
