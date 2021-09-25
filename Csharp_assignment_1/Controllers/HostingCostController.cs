using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Csharp_assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        ///  Method takes an input and performs the necessary calculations using variables for storage and inputs the required string with the necessary information.
        /// </summary>
        public string Get(int id)
        {
            int x = 1 + id / 14;
            double y = 5.5 * x;
            double hst = y * 0.13;
            double t = hst + y;
            return x+" fortnights at $5.50/FN = $"+ y +" CAD" + "\n" + "HST 13% = $ " + hst + " CAD " + "\n" + "Total = $ " + t + " CAD ";
        }
    }
}