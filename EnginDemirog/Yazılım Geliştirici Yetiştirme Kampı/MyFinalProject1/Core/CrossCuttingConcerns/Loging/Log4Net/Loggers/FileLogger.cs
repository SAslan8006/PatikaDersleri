using Core.CrossCuttingConcerns.Loging.Log4Net;
using log4net;

namespace Core.CrossCuttingConcerns.Loging.Log4Net.Loggers
{
    public class FileLogger : LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
    }
}
