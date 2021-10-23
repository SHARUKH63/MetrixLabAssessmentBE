using System.Web.Http;

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
