using Microsoft.AspNet.OData.Builder;
using System.Web.Http;

namespace SchoolsService
{
    public static class ODataApiConfig
    {
        internal static void Register(HttpConfiguration config)
        {
            config.AddApiVersioning();

            VersionedODataModelBuilder modelBuilder = new VersionedODataModelBuilder(config)
            {
                ModelConfigurations =
                {
                    new SchoolModelConfiguration()
                }
            };
            var models = modelBuilder.GetEdmModels();
            config.MapVersionedODataRoutes("odata", "api/v{apiVersion}", models);
        }
    }
}