using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması
{
    class Logs
    {
        static string path = dosyayolu("logs.txt");      
        public static List<string> GetLogs()
        {
            FileControl();
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string row = sr.ReadLine();
                        if (!String.IsNullOrEmpty(row))
                        {
                            list.Add(row.TrimEnd().TrimStart());
                        }
                    }
                }
                catch { }
            }
            return list;
        }
        public static void AddLog(string userName, string log)
        {
            FileControl();
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine($"{DateTime.Now} {userName}: " + log);
            }
        }
        static void FileControl()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public static string dosyayolu(string dosyaadi)
        {
            // string dosyaadi = dosya.dosyayolu("adlar.txt");
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < dosyaYol.Length - 3; i++)
                dosyaYol += dosyaYol[i] + '\\';
            dosyaYol += dosyaadi;
            return dosyaYol;
        }
    }
}
