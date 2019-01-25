using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ArithemeticOperations.Models;
using System.Web.Http;

namespace ArithemeticOperations
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var configs = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // To register the components with the services offered
            builder.RegisterType<Addition>().As<IArithmetic>().InstancePerLifetimeScope();
            builder.RegisterType<Subtraction>().As<IArithmetic>().InstancePerLifetimeScope();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);




            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{num1}/{num2}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
