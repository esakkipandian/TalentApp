using Prft.Talent.Framework.DependencyInjection;
using Prft.Talent.Framework.Extensions;
using Prft.Talent.Services.Abstract;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Prft.Talent.Logger;

namespace Prft.Talent.WebApi.App_Start
{
    internal static class IocConfig
    {
        public const string RootServicesNamespace = nameof(Prft) + "." + nameof(Talent) + "." + nameof(Services);

        internal static Container RegisterDependencies()
        {
            var container = Configure.CreateAndBuildUpContainer(new WebApiRequestLifestyle());

            RegisterServices(container);

            RegisterLogger(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            return container;
        }

        private static void RegisterLogger(Container container)
        {
            container.RegisterConditional(
                        typeof(IPrftLogger),
                        c => typeof(PrftLogger<>).MakeGenericType(c.Consumer.ImplementationType),
                        Lifestyle.Singleton,
                        c => true);
        }

        private static void RegisterServices(Container container)
        {
            var interfaces = typeof(IApi).Assembly.ExportedTypes
                                    .Where(x => x.IsInterface && !x.FullName.EndsWith("IApi")).ToArray();

            var concretes = AppDomain.CurrentDomain
                                    .GetPrftPrivateAssemblies()
                                    .Where(x => x.FullName.StartsWith(RootServicesNamespace))
                                    .SelectMany(a => a.GetExportedTypes())
                                    .Where(c => c.IsClass && c.IsAbstract == false)
                                    .ToArray();

            foreach(var api in interfaces)
            {
                var service = concretes.FirstOrDefault(api.IsAssignableFrom);
                if (service == null) continue;

                container.Register(api, service, Lifestyle.Scoped);
            }

        }
    }

}