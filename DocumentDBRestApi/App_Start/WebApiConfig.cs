using System.Web.Http;

namespace DocumentDBRestApi
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Config"></param>
        public static void Register(HttpConfiguration Config)
        {
            // Web API configuration and services

            // Web API routes
            Config.MapHttpAttributeRoutes();

            Config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
