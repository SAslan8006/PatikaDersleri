using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması
{
    class TransAction
    {
        public static void WithdrawMoney(string userName, int amount)
        {
            Logs.AddLog(userName, $"{amount} TL Çekim Yapıldı.");
            Console.WriteLine($"{amount} TL Çekim Yapıldı.");
        }
        public static void AddUser(string userName)
        {
            LogUser.AddUser(userName);
            Console.WriteLine($"{userName} Kayıt Edildi.");
        }
        public static void LodgementMoney(string userName, int amount)
        {
            Logs.AddLog(userName, $"{amount} TL yatırma işlemi yapıldı.");
            Console.WriteLine($"{amount} Tl yatırma işlemi yapıldı.");
        }
        public static void Payment(string userName, int amount, int debt)
        {
            int newdebt = debt - amount;
            if (newdebt > 0)
            {
                Logs.AddLog(userName, $"{newdebt} TL borcunuz kalmıştır.");
                Console.WriteLine($"{newdebt} TL borcunuz kalmıştır.");
            }
            else if (newdebt == 0)
            {
                Logs.AddLog(userName, $"Borcunuz Bitmiştir.");
                Console.WriteLine($"Borcunuz Bitmiştir.");
            }
            else
            {
                Logs.AddLog(userName, $"Borcunuzdan fazla para yatırdığınız için {amount - debt} Tl iade edilmiştir.");
                Console.WriteLine($"Borcunuzdan fazla para yatırdığınız için {amount - debt} Tl iade edilmiştir.");
            }
        }
        public static void EndOfDayCheck()
        {
            List<string> list = Logs.GetLogs();
            for (int i = list.Count - 1; i > 0; i--)
            {
                DateTime time = Convert.ToDateTime((list[i].Split(list[i][list[i].IndexOf(' ')]))[0]);
                if (time.Day == DateTime.Now.Day && time.Month == DateTime.Now.Month && time.Year == DateTime.Now.Year)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
