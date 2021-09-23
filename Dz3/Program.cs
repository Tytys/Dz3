using System;

namespace Dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberstr;
            int number;
            bool True;
            do
            {
                Console.WriteLine("Введите чило");
                numberstr = Console.ReadLine();
                True = int.TryParse(numberstr, out number);
            } while (!True);
            string numberstr2;
            int number2;
            bool True2;
            do
            {
                Console.WriteLine("Введите число 2");
                numberstr2 = Console.ReadLine();
                True2 = int.TryParse(numberstr2, out number2);
            } while (!True2);
            Console.WriteLine("Результат поразрядного умножения = " + (number & number2));
            Console.WriteLine("Результат поразрядного сложения = " + (number|number2));
            Console.WriteLine("Результат поразрядного сдвига = " + (number<<number2));
            Console.WriteLine("Результат получения дпо кода числа 1 = " + (~number + 1));
            Console.WriteLine("Результат получения дпо кода числа 2 = " + (~number2 + 1));
            Console.ReadKey();
        }
    }
}
