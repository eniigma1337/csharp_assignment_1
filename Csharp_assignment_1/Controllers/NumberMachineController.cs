using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Csharp_assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public double Get(double id)
        {
            return ((id * 10 + 5) / 2 - 5);
        }
    }
}
