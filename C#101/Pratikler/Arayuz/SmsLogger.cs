namespace Arayuz
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Sms Olarak yazar");
        }
    }
}