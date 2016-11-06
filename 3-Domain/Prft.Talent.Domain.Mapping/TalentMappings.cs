using AutoMapper;
using Prft.Talent.Data.Entities;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Mapping
{
    public static class TalentMappings
    {
        public static void RegisterTalentMappings(IProfileExpression profile)
        {
            profile.CreateMap<employee, Employee>();
        }
    }
}
