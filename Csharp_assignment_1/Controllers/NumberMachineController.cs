using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Csharp_assignment_1.Controllers
{
    /// <summary>
    /// Performs a 4 basic arithmetic operations using BODMAS on the inputted integer
    /// </summary>
    public class NumberMachineController : ApiController
    {
        public double Get(double id)
        {
            return ((id * 10 + 5) / 2 - 5);
        }
    }
}
