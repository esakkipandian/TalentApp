using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prft.Talent.Data.Repositories.Abstract;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Logger;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class QualificationRepository : Repository, IQualificationRepository
    {


        public QualificationRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }
        public async Task<IEnumerable<Qualification>> GetQualificationAsync()
        {

            return await Task.Run(() => GetQualificationDetails());
        }

        public IEnumerable<Qualification> GetQualificationDetails()
        {

            return new List<Qualification>
            {
                new Qualification { QualificationCode="UG" ,QualificationName="UnderGraduate",Id=1},
                new Qualification { QualificationCode="PG" ,QualificationName="PostGraduate",Id=2},
                new Qualification { QualificationCode="DR" ,QualificationName="Doctorate",Id=3},
                new Qualification { QualificationCode="OT" ,QualificationName="Others",Id=4}
            };
        }


    }
}




