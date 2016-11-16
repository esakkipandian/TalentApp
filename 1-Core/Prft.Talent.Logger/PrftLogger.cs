using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Prft.Talent.Logger
{
    public class PrftLogger<T> :  IPrftLogger
    {

        private static readonly ILogger logger = LogManager.GetLogger(typeof(T).FullName);

        public void Log(Exception ex, string message)
        {
            logger.Error(ex, message);
        }

        //public void Log( entry)
        //{
        //    if (entry.LoggingEventType == LoggingEventType.Information)
        //        logger.Info(entry.Message, entry.Exception);
        //    else if (entry.LoggingEventType == LoggingEventType.Warning)
        //        logger.Warn(entry.Message, entry.Exception);
        //    else if (entry.LoggingEventType == LoggingEventType.Error)
        //        logger.Error(entry.Message, entry.Exception);
        //    else
        //        logger.Fatal(entry.Message, entry.Exception);
        //}
    }
}
