using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти простые множители
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            while (number > 1)
            {
                for (int i = divider; i <= number; i++)
                {
                    if (number % divider == 0)
                    {
                        number = number / divider;
                        Console.WriteLine(divider);
                    }
                    else
                        divider++;
                }
            }


           

        }
        
    }
}
