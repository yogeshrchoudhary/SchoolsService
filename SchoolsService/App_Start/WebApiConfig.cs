using System.Web.Http;

namespace SchoolsService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // OData API routes
            // Note: OData routes need to be registered 'after' web api routes else you would face a runtime error "ValueFactory attempted to access Value property of this instance
            ODataApiConfig.Register(config);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
