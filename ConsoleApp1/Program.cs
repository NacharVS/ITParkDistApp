using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            double sum = double.Parse(Console.ReadLine());
            if (sum < 0)
                Console.WriteLine("Неправильный ввод");
            else
                Console.WriteLine("Введите количеситво месяцев:");
                int months = int.Parse(Console.ReadLine());
            if (months < 0)
                Console.WriteLine("Неправильный ввод");
            else
            {
                double profit = ((sum / 100) * 4) * months;
                double money = (sum * (Math.Pow(1.04, months)));
                Console.WriteLine(money);
            }






        }
    }
}
