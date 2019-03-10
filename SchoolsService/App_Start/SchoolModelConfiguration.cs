using Microsoft.AspNet.OData.Builder;
using Microsoft.Web.Http;
using SchoolsService.Models;

namespace SchoolsService
{
    internal class SchoolModelConfiguration: IModelConfiguration
    {
        public SchoolModelConfiguration()
        {
        }

        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            //TODO
            builder.EntitySet<School>("Schools");
        }
    }
}