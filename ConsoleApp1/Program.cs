using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int max = 0;
            int MaxSumm = 0;

            for (int i = 1; i <= number; i++)
            {
                int a = i;
                int summ = 0;

                while (a > 0)
                {
                    summ += a % 10;
                    a = a / 10;
                }

                if (MaxSumm < summ)
                {
                    MaxSumm = summ;
                    max = i;
                }
            }
            Console.WriteLine($"number={max}  summ MAX={MaxSumm}");
        }



    }


}

