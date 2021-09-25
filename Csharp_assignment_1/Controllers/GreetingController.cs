using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Csharp_assignment_1.Controllers
{
    /// <summary>
    /// Get request used greets the required number of people that was passed as input. Post request returns Hello World!
    /// </summary>
    public class GreetingController : ApiController
    {
        public string Get(int id)
        {
            return "Greetings to "+ id + " people";
        }
        public string Post()
        {
            return "Hello World!";
        }
    }
}
