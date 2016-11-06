using Prft.Talent.Framework.Extensions;
using SimpleInjector;
using SimpleInjector.Extensions.LifetimeScoping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prft.Talent.Framework.DependencyInjection
{
    public static class Configure
    {
        public static Container CreateAndBuildUpContainer(ScopedLifestyle defaultScopedLifestyle = null)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = defaultScopedLifestyle ?? new LifetimeScopeLifestyle();
            
            foreach(var bootstrapType in GetIBootstrapImplementations())
            {
                var bootstrap = Activator.CreateInstance(bootstrapType) as IBootstrap;
                bootstrap.Configure(container);
            }

            return container;
        }

        private static IEnumerable<Type> GetIBootstrapImplementations()
        {
            return AppDomain.CurrentDomain
                 .GetPrftPrivateAssemblies()
                 .SelectMany(a => a.GetExportedTypes())
                 .Where(t => t.IsClass && t.IsAbstract == false && t.GetInterface(nameof(IBootstrap)) == typeof(IBootstrap));
        }
    }
}
