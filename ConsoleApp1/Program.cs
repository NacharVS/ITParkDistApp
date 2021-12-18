using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        static int GetSize(string inquiry)
        {
            Console.WriteLine(inquiry);
            return int.Parse(Console.ReadLine());
        }

        static void GetArray(int[,] array, Random rnd)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }
            PrintArray(array);
        }

        static int[,] ArraySumm1(int[,] array1, int[,] array2)
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
                }
            }
            return arraySum;
        }

        static int[,] ArraySumm2(int[,] array1, int[,] array2)
        {
            int[,] arraySum;
            
            Console.WriteLine();

            if (array1.GetLength(0) < array2.GetLength(0) && array1.GetLength(1) < array2.GetLength(1))
            {
                arraySum = new int[array1.GetLength(0), array1.GetLength(1)];
            }

            else if (array1.GetLength(0) < array2.GetLength(0) && array1.GetLength(1) > array2.GetLength(1))
            {
                arraySum = new int[array1.GetLength(0), array2.GetLength(1)];
            }

            else if (array1.GetLength(0) > array2.GetLength(0) && array1.GetLength(1) < array2.GetLength(1))
            {
                arraySum = new int[array2.GetLength(0), array1.GetLength(1)];
            }

            else if (array1.GetLength(0) > array2.GetLength(0) && array1.GetLength(1) > array2.GetLength(1))
            {
                arraySum = new int[array2.GetLength(0), array2.GetLength(1)];
            }

            else
            {
                Console.WriteLine("Error!!!");
                arraySum = new int[0, 0];
                return arraySum;
            }

            for (int i = 0; i < arraySum.GetLength(0); i++)
            {
                for (int j = 0; j < arraySum.GetLength(1); j++)
                {
                    arraySum[i, j] = array1[i, j] + array2[i, j];
                }
            }
            return arraySum;
        }

        static int[,] ArraySumm3(int[,] array1, int[,] array2)
        {
            int[,] arraySum;

            Console.WriteLine();

            if (array1.GetLength(0) < array2.GetLength(0) && array1.GetLength(1) < array2.GetLength(1))
            {
                arraySum = new int[array2.GetLength(0), array2.GetLength(1)];
            }

            else if (array1.GetLength(0) < array2.GetLength(0) && array1.GetLength(1) > array2.GetLength(1))
            {
                arraySum = new int[array2.GetLength(0), array1.GetLength(1)];
            }

            else if (array1.GetLength(0) > array2.GetLength(0) && array1.GetLength(1) < array2.GetLength(1))
            {
                arraySum = new int[array1.GetLength(0), array2.GetLength(1)];
            }

            else if (array1.GetLength(0) > array2.GetLength(0) && array1.GetLength(1) > array2.GetLength(1))
            {
                arraySum = new int[array1.GetLength(0), array1.GetLength(1)];
            }

            else
            {
                Console.WriteLine("Error!!!");
                arraySum = new int[0, 0];
                return arraySum;
            }

            for (int i = 0; i < arraySum.GetLength(0); i++)
            {
                for (int j = 0; j < arraySum.GetLength(1); j++)
                {
                    if (i < array1.GetLength(0) && i < array2.GetLength(0) && j < array1.GetLength(0) && j < array2.GetLength(0))
                    {
                        arraySum[i, j] = array1[i, j] + array2[i, j];
                    }

                    else
                    {
                        arraySum[i, j] = 0;
                    }
                    
                }
            }
            return arraySum;
        }

        static void PrintArray(int [,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            bool key = true;

            int sizeA;
            int sizeB;

            int sizeA1;
            int sizeA2;
            int sizeB1;
            int sizeB2;

            int[,] arrayA;
            int[,] arrayB;

            Random rnd = new Random();

            int[,] arraySum;

            

            while (key)
            {
                Console.WriteLine();
                Console.WriteLine("Select job number or exit 1/ 2/ 3 or 0:");
                int jobNumber = int.Parse(Console.ReadLine());

                switch (jobNumber)
                {
                    case 0:
                        key = false;
                        break;

                    case 1:
                        sizeA = GetSize("Enter the size of the first matrix:");
                        sizeB = GetSize("Enter the size of the second matrix:");

                        arrayA = new int[sizeA, sizeA];
                        GetArray(arrayA, rnd);

                        arrayB = new int[sizeB, sizeB];
                        GetArray(arrayB, rnd);

                        arraySum = ArraySumm1(arrayA, arrayB);

                        PrintArray(arraySum);
                       
                        break;

                    case 2:
                        sizeA1 = GetSize("Enter the size one of the first array:");
                        sizeA2 = GetSize("Enter the size two of the first array:");
                        sizeB1 = GetSize("Enter the size one of the second array:");
                        sizeB2 = GetSize("Enter the size two of the second array:");

                        arrayA = new int[sizeA1, sizeA2];
                        GetArray(arrayA, rnd);

                        arrayB = new int[sizeB1, sizeB2];
                        GetArray(arrayB, rnd);

                        arraySum = ArraySumm2(arrayA, arrayB);

                        PrintArray(arraySum);

                        break;

                    case 3:
                        sizeA1 = GetSize("Enter the size one of the first array:");
                        sizeA2 = GetSize("Enter the size two of the first array:");
                        sizeB1 = GetSize("Enter the size one of the second array:");
                        sizeB2 = GetSize("Enter the size two of the second array:");

                        arrayA = new int[sizeA1, sizeA2];
                        GetArray(arrayA, rnd);

                        arrayB = new int[sizeB1, sizeB2];
                        GetArray(arrayB, rnd);

                        arraySum = ArraySumm3(arrayA, arrayB);

                        PrintArray(arraySum);

                        break;

                    default:
                        Console.WriteLine("You entered the wrong job number!");
                        break;
                }
            }

            




            






        }
    }
}
