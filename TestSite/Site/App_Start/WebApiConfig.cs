using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Api;
using Autofac.Integration.WebApi;

namespace Site
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services     
            // Web API routes
            config.MapHttpAttributeRoutes();

            var container = ApiKernel.Instance.Container;

            //Integrate Autofac
            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
