using System;

namespace Business.CCS
{
    public class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı.");
        }
    }

}
