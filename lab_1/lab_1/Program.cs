using System;
using System.Collections.Generic;




namespace ConsoleApplication1
{
    class Program
    {
        static double Factorial(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static void Main()
        {
            double answer;
            Console.WriteLine("Выберете какое здание вы хотите запустить:");
            Console.WriteLine("1 - если хотите решить квадратное уравнение");
            Console.WriteLine("2 - если хотите найти факториал");
            Console.WriteLine("3 -  приложение для ввода с клавиатуры массива строк и поиска среди них строк, содержащих заданный строковый фрагмент");
            Console.WriteLine("4 - Дан массив из 140 элементов, диапазон значений -100 - 100 Вывести начальные индексы всех непрерывных последовательностей неотрицательных чисел, длина которых больше 5");
            answer = Convert.ToDouble(Console.ReadLine());
            if (answer == 1)
            {
                Double a, b, c, D, x1, x2;
                Console.WriteLine("..............................................................");
                Console.WriteLine("Программа вычисления квадратного корня с помощью дискриминанта");
                Console.WriteLine("..............................................................");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                
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
            if(answer==2){
                double x;
                Console.WriteLine("Введите число");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Factorial(x));
            }
            
            
            
            
            if (answer == 3) 
            {
                var arr = new List<string>();
                var res = new List<string>();

                Console.Write("Введите слово для поиска:");
                string word = Console.ReadLine();
                for(int i = 0;i < 5; i++)
                {
                    Console.WriteLine("Введите строку: ");
                    arr.Add(Console.ReadLine());
                }
                for(int i = 0; i<arr.Count ; i++)
                {
                    if (arr[i].IndexOf(word) >= 0)
                        res.Add(arr[i]);
                }
                Console.WriteLine("Результат:");
                for (int i = 0; i < res.Count; i++)
                {
                    Console.WriteLine(res[i]);
                }

            }





            var rand = new Random();
            int[] nums = new int[145];
            if (answer == 4)
            {
                for (int i = 0; i < 140; i++)
                     nums[i] = rand.Next(-100, 100);
                Console.WriteLine("чайно сгенерированый массив значений от -100 до 100");
                for (int i = 0; i < 140; i++)
                    Console.WriteLine(nums[i]);
                for (int i = 0; i < 140; i++){
                    int num = 0;        
                    while (nums[i] > 0)
                    {
                        i++;
                        num++;
                    }
                    if (num >= 5)
                    {
                        Console.WriteLine("Индекс начала последовательности:");
                        Console.WriteLine(i);
                    }
                    
                }

            }
        }
    }
}