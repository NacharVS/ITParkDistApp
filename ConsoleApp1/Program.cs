using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a, b, c;

            Console.WriteLine("Среднее порядковое число.\n");

            Console.Write("Введите первое число: ");
            a = short.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = short.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = short.Parse(Console.ReadLine());

            if ((a > b && a < c) || (a < b && a > c))
                Console.WriteLine(a);
            else if ((b > a && b < c) || (b < a && b > c))
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
            }
        }
    }
}
