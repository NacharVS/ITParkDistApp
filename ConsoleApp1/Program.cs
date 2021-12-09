using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1; // 16468644
            int summ = 0;

            for (int i = number; i > 0; i = i / 10)
            {
                summ += number % 10;
                number = number / 10;
            }
            Console.WriteLine(summ);
        }
        

    }
}
