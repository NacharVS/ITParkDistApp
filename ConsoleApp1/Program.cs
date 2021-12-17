using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        static void ArrayGeneric2(int[,] array, Random rnd)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }    
        } 

        static void ArraySumm(int[,] arraySizeMore, int[,] arraySizeLess, int[,] arraySumm)
        {
            Console.WriteLine();
            
            for (int i = 0; i < arraySumm.GetLength(0); i++)
            {
                for (int j = 0; j < arraySumm.GetLength(1); j++)
                {
                    if (i < arraySizeLess.GetLength(0) && j < arraySizeLess.GetLength(1))
                    {
                        arraySumm[i,j] = arraySizeMore[i,j] + arraySizeLess[i,j];
                    }
                    else
                    {
                        arraySumm[i, j] = arraySizeMore[i, j];
                    }

                    Console.Write($"{arraySumm[i, j]}\t");

                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            //Entering matrix sizes.
            Console.WriteLine("Enter the size of the first matrix:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second matrix:");
            int b = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int[,] arrayA = new int[a,a];
            int[,] arrayB = new int[b,b];
            int[,] arraySum;

            //Filling matrices with random numbers.
            ArrayGeneric2(arrayA, rnd);
            ArrayGeneric2(arrayB, rnd);
                   
            if (a > b)
            {
                arraySum = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
                ArraySumm(arrayA, arrayB, arraySum);
            }

            else if (a < b)
            {
                arraySum = new int[arrayB.GetLength(0), arrayB.GetLength(1)];
                ArraySumm(arrayB, arrayA, arraySum);
            }

            else Console.WriteLine("Error.");
        }
    }
}
