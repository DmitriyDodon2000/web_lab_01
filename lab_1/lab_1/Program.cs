using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Double a, b, c, D, x1, x2;
            Console.WriteLine("..............................................................");
            Console.WriteLine("Программа вычисления квадратного корня с помощью дискриминанта");
            Console.WriteLine("..............................................................");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("....................Нажмите для ввода.................");
            Console.ReadLine();

            Console.WriteLine("Введите а, b, c");
            Console.ForegroundColor = ConsoleColor.Yellow;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D >= 0 && a != 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("X1 =  X2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
            Console.ReadLine();
            Console.Read();
        }


    }

}