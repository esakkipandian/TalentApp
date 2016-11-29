using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prft.Talent.Domain.Talent;
namespace Prft.Talent.Services.Api
{
    public class SourceResponse : ResponseBase
    {
        public IEnumerable<Source> Source { get; set; }
    }

}
