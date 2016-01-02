using AngularMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularMasterDetail.Controllers
{
    public class MasterDetController : ApiController
    {
        public IEnumerable<Customer> Get()
        {
            return new List<Customer>{ new Customer{ CustomerID="100", City="salem", CompanyName="ANB"},
                                        new Customer{ CustomerID="200", City="singapore", CompanyName="GIC"}};
        }
    }
}
