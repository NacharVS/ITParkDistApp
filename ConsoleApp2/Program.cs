using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;

            Console.WriteLine("\nПроверка на чётность.\n");

            Console.Write("Введите трёхзначное число: ");
            a = short.Parse(Console.ReadLine());

            if (a % 2 == 1)
            {
                Console.WriteLine(a + " нечётное число.\nПроизведение цифр числа равно: " + ((a / 100) * (a / 10 % 10) * (a % 10)));
            }
            else
            {
                Console.WriteLine(a + " чётное число.\nСумма цифр числа равна: " + (a / 100 + a / 10 % 10 + a % 10));
            }
        }
    }
}
