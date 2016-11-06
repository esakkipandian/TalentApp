using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json.Converters;
using System.Net.Http.Headers;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Concrete;
using Prft.Talent.WebApi.App_Start;

namespace Prft.Talent.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            ConfigureContainer();
        }

        private void ConfigureContainer()
        {

            IocConfig.RegisterDependencies();

            //var container = new Container();
            //container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            //// Register your types, for instance using the scoped lifestyle:
            //container.Register<IEmployeeService, EmployeeService>(Lifestyle.Scoped);

            //// This is an extension method from the integration package.
            //container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            //container.Verify();

            //GlobalConfiguration.Configuration.DependencyResolver =
            //    new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
