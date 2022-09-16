namespace Arayuz
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Dosyaya yazar");
        }
    }
}