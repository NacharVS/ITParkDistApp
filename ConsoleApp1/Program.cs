using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = int.Parse(Console.ReadLine());
            int combinations = 0;// 1 < summ < 27
            for (int i = 0; i <= 7; i++)
            {
                for (int j = i + 1; j <= 8; j++)
                {

                    for (int k = j + 1; k <= 9; k++)
                    {
                        if (i + j + k == summ && i != j && j != k && i != k)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                            break;
                        }
                    }

                }

            }
            Console.WriteLine($" count {combinations}");
        }
    }

}

