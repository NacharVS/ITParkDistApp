using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int maxsumm = 0;
            for (int i = 1; i <= n; i++)
            { 
                int a = i;
                int summ = 0;
                while (a > 0)
                {
                    summ += a % 10;
                    a = a / 10;
                }
                if (maxsumm < summ)
                {
                    maxsumm = summ;
                    max = i;
                }
            }
            Console.WriteLine($"Число {max} Сумма цифр {maxsumm}");





        }
    }
}

