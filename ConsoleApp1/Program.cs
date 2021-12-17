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
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] ArraySumm(int[,] array1, int[,] array2)
        {
            int[,] arraySum;
            int[,] arraySizeMore;
            int[,] arraySizeLess;

            Console.WriteLine();

            if (array1.GetLength(0) > array2.GetLength(0))
            {
                arraySum = new int[array1.GetLength(0), array1.GetLength(1)];
                arraySizeMore = array1;
                arraySizeLess = array2;
            }

            else 
            {
                arraySum = new int[array2.GetLength(0), array2.GetLength(1)];
                arraySizeMore = array2;
                arraySizeLess = array1;
            }
            
            for (int i = 0; i < arraySum.GetLength(0); i++)
            {
                for (int j = 0; j < arraySum.GetLength(1); j++)
                {
                    if (i < arraySizeLess.GetLength(0) && j < arraySizeLess.GetLength(1))
                    {
                        arraySum[i, j] = arraySizeMore[i, j] + arraySizeLess[i, j];
                    }
                    else
                    {
                        arraySum[i, j] = arraySizeMore[i, j];
                    }

                    Console.Write($"{arraySum[i, j]}\t");

                }
                Console.WriteLine();
            }

            return arraySum;
        }


        static void Main(string[] args)
        {
            //Entering matrix sizes.
            Console.WriteLine("Enter the size of the first matrix:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the second matrix:");
            int b = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int[,] arrayA = new int[a, a];
            int[,] arrayB = new int[b, b];
            int[,] arraySum;

            //Filling matrices with random numbers.
            ArrayGeneric2(arrayA, rnd);
            ArrayGeneric2(arrayB, rnd);

            arraySum = ArraySumm(arrayA, arrayB);






        }
    }
}
