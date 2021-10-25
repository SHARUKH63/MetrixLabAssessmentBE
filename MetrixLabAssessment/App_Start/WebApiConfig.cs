using System.Web.Http;
using System.Web.Http.Cors;

namespace MetrixLabAssessment
{
    /// <summary>
    /// Web api config class.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registeres the default configurations for web api project.
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration"/>.</param>
        public static void Register(HttpConfiguration config)
        {
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

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
