using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Csharp_assignment_1.Controllers
{
    /// <summary>
    ///  Squares the number passed as id and returns it;
    /// </summary>
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return id * id;
        }
    }
}
