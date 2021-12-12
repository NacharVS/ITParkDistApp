using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            int[] summs = new int[array.GetLength(0)];
            Random rnd = new Random();
            //сумма в каждой строке массива

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(2);
                    summs[i] += array[i, j];
                    Console.Write($"{array[i,j]} ");
                }                           
                Console.WriteLine();
            }
            for (int i = 0; i < summs.Length; i++)
            {
                Console.WriteLine($"{i+1}. {summs[i]}");
            }

            
            for (int j = 0; j < summs.Length - 1; j++)
            {
                for (int i = 0; i < summs.Length - 1-j; i++)
                {
                    if (summs[i] > summs[i + 1])
                    {
                        int buffer = summs[i + 1];
                        summs[i + 1] = summs[i];
                        summs[i] = buffer;
                    }
                    
                }
            }


            Console.WriteLine();
            Console.WriteLine("sorted summs:");
            foreach (var item in summs)
            {
                Console.Write($"{item} ");
            }

        }
        
    }
}
