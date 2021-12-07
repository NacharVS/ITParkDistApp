using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount"); //Пожалуйста, введите сумму
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of months"); //Пожалуйста, введите количество месяцев
            int months = Convert.ToInt32(Console.ReadLine());
            if (money>0 && months>0)
            {
                double accumulation = money * Math.Pow(1.04, months);
                Console.WriteLine($"Amount of savings={accumulation}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect data");
                Console.ReadKey();
            }

        }
    }
}
