using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upr.Konstr
{
    internal class Program
    {
        static void Login()
        {
            string login, password;
            int count = 0;
            do
            {
                count++;
                Console.WriteLine("Введите логин");
                Console.Write("Логин: ");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                Console.Write("Пароль: ");
                password = Console.ReadLine();
                if (login == "root" && password == "GeekBrains")
                {
                    Console.SetCursorPosition(50, 100);
                    Console.WriteLine("Вход выполнен успешно!");
                    bool f = true;
                    while (f == true)
                    {
                        Info.info(2, "Трубин  Вячеслав Сергеевич");
                        Console.WriteLine("Выберите задание 1 - 4, 0 выход из заданий ");

                        int zadanie = int.Parse(Console.ReadLine());

                        switch (zadanie)
                        {
                            case 0:
                                f = false;
                                break;
                            case 1:
                                minchislo();
                                break;
                            case 2:
                                ves();
                                break;
                            case 3:
                                chisla();
                                break;
                            default:
                                Console.WriteLine("Нет такой задачи");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Логин или пароль неверный");
                    Console.WriteLine($"Попытка {count} \n");
                    if (count == 3)
                    {
                        Console.SetCursorPosition(50, 100);
                        Console.WriteLine("НЕТ ДОСТУПА!");
                    }
                }

            }

            while (count < 3);
        }
        static void minchislo()
        {
            Console.WriteLine("Ищем минимальное число из 3");
            Console.WriteLine("Введите число a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = double.Parse(Console.ReadLine());
            if (a == b && c == b && a == c)
            {
                Console.WriteLine("Вы ввели 3 одинаковых числа");
            }
            else if (a > b && a > c)
            {
                Console.WriteLine($"a = {a} > b и c \n");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"b = {b} > a и c \n");
            }
            else
                Console.WriteLine($"c = {c} > a и b \n");
        }
        static void ves()
        {
            Console.WriteLine("Задача с ИМТ");
            Console.WriteLine("Введите вес в кг: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в см: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double I = m / (h / 100 * h / 100);
            Console.WriteLine("Индекс массы тела равен " + "{0:F}", I);
            Console.WriteLine();
            if (I <= 18.5)
            {
                Console.WriteLine("Масса тела недостаточная");
            }
            else if (I > 18.5 && I < 24.9)
            {
                Console.WriteLine("Масса тела нормальная");
            }
            else
            {
                Console.WriteLine("Избыточная масса");
            }

            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();
        }
        static void chisla()
        {
            {
                int a = 0;
                int b = 0;

                do
                {
                    Console.WriteLine("Введите число");
                    b = int.Parse(Console.ReadLine());
                    if (b > 0 && b % 2 == 1)
                        a += b;

                } while (b != 0);

                Console.WriteLine("Sum: " + a);
            }
        }
        static void Main(string[] args)
        { 
            Login();
            chisla();
        }
    }
}

