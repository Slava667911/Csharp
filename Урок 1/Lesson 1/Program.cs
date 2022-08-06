using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
      
        static void Koordinate()
        {
            Console.WriteLine("Задача с координатами");
            double r;
            Console.WriteLine("Введите x1");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            float y2 = float.Parse(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(" r = {0:F}", r + "\n");
            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();
        }
        static void Anketa()
        {
            Console.WriteLine("Задача с Анкетой");
            Console.WriteLine("Ваше имя?");
            string Name = Console.ReadLine();
            Console.WriteLine("Ваша Фамилия?");
            string Surname = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш рост?");
            double Size = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваш вес?");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Имя:" + Name + ", Фамилия:" + Surname + ", Возраст:" + Age + " лет" + ", Рост:" + Size + " см" + ", Вес " + Weight + " кг");
            Console.WriteLine("Имя:{0}, Фамилия:{1}, Возраст:{2} лет, Рост:{3} см, Вес:{4} кг", Name, Surname, Age, Size, Weight);
            Console.WriteLine($"Имя:{Name}, Фамилия:{Surname}, Возраст:{Age} лет, Рост:{Size} см, Вес:{Weight} кг \n ");
            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();
        }
        static void IMT()
        {
            Console.WriteLine("Задача с ИМТ");
            Console.WriteLine("Введите вес в кг: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в см: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Индекс массы тела равен, I = " + "{0:F}", m / (h * h) + "\n");
            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();
        }
        static void Perem()
        {
            Console.WriteLine("Задача с 3 переменными");
            int a = 43;
            int b = 17;
            Console.WriteLine($"a = {a}, b = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}, b = {b}");

            Console.WriteLine("Задача с 2 переменными");
            int x = 10;
            int y = 20;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            x = x + y; //30 x
            y = x - y; // 10 y
            x = x - y;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();


        }
        static void Print()
        {
            Console.SetCursorPosition(50, 50); // позиция курсора
            Console.WriteLine("Привет!!! \n");
            Console.WriteLine("Нажмите Enter, что бы продолжить");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
               Info.Info.PrivatInfo( 1, "Трубин Вячеслав Сергеевич");
                Console.WriteLine("Выберите задачу 1- 5 \n 1 - Анкета \n 2 - Масса тела \n 3 - координаты \n 4 - Переменные \n 5 - Привет в центре");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        f = false;
                        break;
                    case 1:
                        Anketa();
                        break;
                    case 2:
                        IMT();
                        break;
                    case 3:
                        Koordinate();
                        break;
                    case 4:
                        Perem();
                        break;
                    case 5:
                        Print();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи!!! \n");
                        break;
                }
            }
            
           
            
           






        }
    }
}
