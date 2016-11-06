using Prft.Talent.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using AutoMapper;

namespace Prft.Talent.Domain.Mapping
{
    public class IocRegistration : IBootstrap
    {
        public void Configure(Container container)
        {
            RegisterAutoMapper(container);
        }

        private void RegisterAutoMapper(Container container)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                TalentMappings.RegisterTalentMappings(cfg);
            });

            container.RegisterSingleton(mapperConfiguration.CreateMapper());
        }
    }
}
