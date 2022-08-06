using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class Info
    {
        public static void PrivatInfo(int homeworkNumber, string fio)
        {
            Console.WriteLine($"Домашняя работа {homeworkNumber}");
            Console.WriteLine($"Мои Ф.И.О: {fio}");
            Console.WriteLine("================================");
        }
    }
}
