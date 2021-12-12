using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = int.Parse(Console.ReadLine());
            int combinations = 0;// 1 < summ < 27
            int a = 0;
            int b = a;
            for (int i = 0; i <= 7; i++)
               // if (i!=1)
            {
                for (int j = 1; j <= 8; j++)
                    if (j!=a)
                {
                        
                    for (int k = 2; k <= 9; k++)
                    {
                        if (i + j + k == summ && i != j && j != k && i != k)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                            a = k;
                            break;
                        }
                    }

                }

            }
            Console.WriteLine($" count {combinations}");
        }
    }

}

