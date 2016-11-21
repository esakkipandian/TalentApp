using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
  public  class CollegesReponse:ResponseBase
    {
        public IEnumerable<Colleges> Colleges { get; set; }
    }
}
