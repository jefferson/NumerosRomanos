using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppNumerosRomanos.Controllers
{
    public class ConvertController : ApiController
    {
        
        // GET api/values/5
        public string Get(int id)
        {
            WebAppNumerosRomanos.Models.Convert.toRoman(112);

            return "value";
        }

        // GET api/values/5
        public string Get()
        {
            return "value";
        }


    }
}
