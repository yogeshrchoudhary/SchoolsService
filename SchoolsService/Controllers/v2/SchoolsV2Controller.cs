using Microsoft.Web.Http;
using SchoolsService.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchoolsService.Controllers.v2
{
    [
        ApiVersion("2.0"), 
        ControllerName("Schools")
    ]
    public class SchoolsV2Controller : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            await Task.Yield();
            return Json(new School[] { new School { Id = 3, Name = "XYZ School" } });
        }
    }
}
