using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upr.Konstr
{
   public class Info
    {
        public static void info(int numberHomework , string fio)
        {
            Console.WriteLine($"Домашняя работа = {numberHomework} " );
            Console.WriteLine($"Мои Ф.И.О = {fio}");
            Console.WriteLine("_______________________________________________________");
            
        }
    }
}
