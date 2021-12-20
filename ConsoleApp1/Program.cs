using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Разложение числа на простын множители: ");
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)   //while (num % i == 0)
                {
                    num = num / i;
                    Console.Write(i);
                }
            }
        }
    }
}

