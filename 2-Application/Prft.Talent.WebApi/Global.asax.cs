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
using Newtonsoft.Json.Serialization;
using System.Web.Http.ExceptionHandling;
using Prft.Talent.WebApi.Exception;

namespace Prft.Talent.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            config.Services.Replace(typeof(IExceptionHandler), new PrftExceptionHandler());

            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            IocConfig.RegisterDependencies();
        }
    }
}
