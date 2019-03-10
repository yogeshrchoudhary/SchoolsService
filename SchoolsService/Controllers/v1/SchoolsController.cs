using Microsoft.AspNet.OData;
using Microsoft.Web.Http;
using SchoolsService.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchoolsService.Controllers.v1
{
    [
        ApiVersion("1.0"), 
        ControllerName("Schools")
    ]
    public class SchoolsV1Controller : ODataController
    {
        private readonly IEnumerable<School> _mockSchools = new School[]  {
            new School{Id = 1,
                Name = "Green Abbey Secondary School",
                Established = new DateTimeOffset(new DateTime(1990, 10, 1)),
                PhoneNumber = "+31 789012345"},
            new School{Id = 2,
                Name = "Water's Edge Primary School",
                Established = new DateTimeOffset(new DateTime(1989, 9, 8)),
                PhoneNumber = "+31 6578493021"}
        };

        public async Task<IHttpActionResult> Get()
        {
            await Task.Yield();
            return Json(_mockSchools);
        }
    }
}
