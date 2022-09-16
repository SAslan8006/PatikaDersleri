namespace Arayuz
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Database'e yazar");
        }
    }
}