using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок3
{

    class Complex
    {
        #region Public Methods

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re + complex.Re;
            c._im = _im + complex._im;
            return c;
        }
        
        

        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <returns> Результат вычитания комплексных чисел</returns>
        public Complex Minus(Complex complex)
        {
            Complex l = new Complex();
            l.Re = _re - complex.Re;
            l._im = _im - complex._im;
            return l;
        }
        /// <summary>
        /// Перегрузка оператора -, вычитание комплексных чисел
        /// </summary>
        /// <param name="complex3">Комплексное число</param>
        /// <param name="complex4">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator -(Complex complex3, Complex complex4)
        {
            return new Complex { Re = complex3.Re - complex4.Re, Im = complex3.Im - complex4.Im };
        }




        public override string ToString()
        {
            return $"{_re} {_im}i";
        }
        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }

    class Program
    {
        static string Console_message = "Введите число";


        static void chisla(string message)
        {
            int sum = 0;
            int num = 0;
            bool flag;
            string s;
           
            do
            {
                Console.WriteLine("Введите число: ");
                s = Console.ReadLine();
                flag = int.TryParse(s, out num);
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);
           
            Console.WriteLine("Sum: " + sum);

        }
        static void ShowValue(string decription)
        { 
        
        }


       
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(5, -2);
            Complex complex2 = new Complex(-1, 3);
            Complex complex3 = new Complex(11, -31);
            Complex complex4 = new Complex(-17, 41);

            Console.WriteLine($"Работа с комплексными числами {complex1} и {complex2}");
            Console.WriteLine($"Результат сложения комплексных чисел {complex1 + complex2}");

            Console.WriteLine($"Работа с комплексными числами {complex3} и {complex4}");
            Console.WriteLine($"Результат вычитания комплексных чисел {complex3 - complex4}");



           chisla(Console_message);










            Console.ReadLine();
        }
    }
}