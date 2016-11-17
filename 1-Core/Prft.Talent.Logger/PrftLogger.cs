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

        public void Log(string logContent)
        {
            logger.Log(LogLevel.Info, logContent);
        }

        public void Log(PrftLogLevel logLevel, Exception ex, string message)
        {
            switch (logLevel)
            {
                case PrftLogLevel.Trace:
                    logger.Trace(ex, message);
                    break;
                case PrftLogLevel.Debug:
                    logger.Debug(ex, message);
                    break;
                case PrftLogLevel.Info:
                    logger.Info(ex, message);
                    break;
                case PrftLogLevel.Warning:
                    logger.Warn(ex, message);
                    break;
                case PrftLogLevel.Error:
                    logger.Error(ex, message);
                    break;
                case PrftLogLevel.Fatal:
                    logger.Fatal(ex, message);
                    break;
            }
        }
    }
}
