using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması
{
    public partial class LogUser
    {
       

        private static string dosyayolu(string dosyaadi)
        {
            // string dosyaadi = dosya.dosyayolu("adlar.txt");
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < dosyaYol.Length - 3; i++)
                dosyaYol += dosyaYol[i] + '\\';
            dosyaYol += dosyaadi;
            return dosyaYol;
        }

        static string path = dosyayolu("userLog.txt");
        
        public static bool UserControl(string userName)
        {
            if (LogUser.GetUsers().Contains(userName))
                return true;
            else return false;
        }
        public static List<string> GetUsers()
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
        public static void AddUser(string userName)
        {
            FileControl();

            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine(userName.TrimEnd().TrimStart());
            }
        }
        static void FileControl()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

    }
    public class User
    {
        private string userName;
        public User(string userName)
        {
            this.userName = userName;
        }
    }
}

