
namespace Arayuz
{
    public class LogManager:ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger Logger)
        {
            _logger = Logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}