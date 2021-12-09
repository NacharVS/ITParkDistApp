using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11223344; // 1234 ==> 4321
            int summ = 0;

            while (number > 0)
            {
                summ = summ * 10 + number % 10;
                number = number / 10;
            }

            Console.WriteLine(summ);
        }
        

    }
}
