using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services
{
    public abstract class ResponseBase
    {
        public static T CreateEmptyResponse<T>() where T : ResponseBase, new()
        {
            return new T();
        }
    }
}
