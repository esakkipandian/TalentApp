using Prft.Talent.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Data.Repositories.Concrete;

namespace Prft.Talent.Data.Repositories
{
    public class IocRegistration : IBootstrap
    {
        public void Configure(Container container)
        {
            //container.Register<RepositoryDependencies>(Lifestyle.Scoped);
            container.Register<PrftDatabaseContext>(Lifestyle.Scoped);
            RegisterRepositories(container);
        }

        private void RegisterRepositories(Container container)
        {
            var repositoryInterfaces = typeof(IRepository).Assembly
                                        .GetExportedTypes()
                                        .Where(x => x.IsInterface && x != typeof(IRepository) && typeof(IRepository).IsAssignableFrom(x))
                                        .ToArray();

            var repositoryImplementations = typeof(Repository).Assembly
                                            .GetExportedTypes()
                                            .Where(x => x != typeof(Repository) && typeof(Repository).IsAssignableFrom(x))
                                            .ToArray();

            foreach(var repositoryInterface in repositoryInterfaces)
            {
                var implementation = repositoryImplementations.FirstOrDefault(repositoryInterface.IsAssignableFrom);
                if (implementation == null) throw new InvalidOperationException($"Unable to loacate implementation for  { repositoryInterface.FullName }");

                container.Register(repositoryInterface, implementation, Lifestyle.Scoped);
            }
        }
    }
}
