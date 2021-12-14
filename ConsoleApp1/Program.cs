using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите трехзначное число:");
            int number= int.Parse(Console.ReadLine());
            int ed = number % 10;
            int des = number / 10 % 10;
            int hun = number / 100;
            if (number % 2 <= 0)
                Console.WriteLine($"четное. Сумма цифр:{ed + des + hun}");
            else
                Console.WriteLine($"нечетное. Произведение цифр:{ed * des * hun}");
            

           


                





        }
    }
}