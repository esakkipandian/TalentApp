using Prft.Talent.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Prft.Talent.WebApi.Exception
{
    public class PrftExceptionHandler : ExceptionHandler
    {
        private static readonly PrftLogger<PrftExceptionHandler> _logger = new PrftLogger<PrftExceptionHandler>();

        public override void Handle(ExceptionHandlerContext context)
        {
            _logger.Log(PrftLogLevel.Error, context.Exception, "Unhandled Exception Occurred.");
        }
    }
}