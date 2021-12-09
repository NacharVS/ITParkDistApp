using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = int.Parse(Console.ReadLine());
            int combinations = 0;// 1 < summ < 27
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i + j + k == summ && i != j && j!= k && i!=k )
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine($" count {combinations}");
        }
        

    }
}
