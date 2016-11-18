using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using Prft.Talent.Logger;


namespace Prft.Talent.Services.Concrete
{
    public class CollegesService : ICollegesServices
    {
        private readonly ICollegesRepository _collegeTypeRepository;
        private readonly IPrftLogger _logger;

        public CollegesService(ICollegesRepository collegeRepository, IPrftLogger logger)
        {

            _collegeTypeRepository = collegeRepository;
            _logger = logger;
        }

       

        public async  Task<CollegesReponse> GetCollegesAsync()
        {

            return new CollegesReponse
            {
                Collges = await _collegeTypeRepository.GetCollegesAsync()
            };
           
        }

        
    }
}
