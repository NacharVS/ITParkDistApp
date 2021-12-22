using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayOperations
    {
        public static void ArrayGeneration(int[,] array, Random rnd)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }
            ArrayOperations.PrintArray(array);
        }

        public static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 2);

                Console.Write(array[i] + " ");
            }
        }

        public static void ArrayGeneration(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rnd.Next(0, 2);

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayGeneration(int[] array, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n);

                Console.Write(array[i] + " ");
            }
        }

        public static void ArrayGeneration(int[,] array, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rnd.Next(n);

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayGeneration(int[] array, int n, int m)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n, m);

                Console.Write(array[i] + " ");
            }
        }

        public static void ArrayGeneration(int[,] array, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rnd.Next(n, m);

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    
        public static void ArraySorting(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int buffer = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = buffer;
                    }
                }
            }

            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        public static void ArraySorting(int[] array, bool flag)
        {
            if (flag)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1 - j; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int buffer = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = buffer;
                        }
                    }
                }

                Console.WriteLine();

                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
            }

            else ArraySorting(array);

        }

        public static void ArrayRowSumm(int[,] array, SummID[] sumID)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumID[i].rowId = i + 1;
                sumID[i].summInRow = 0;
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumID[i].summInRow += array[i,j];
                }
            }
        }

        public static void PrintArray(int[,] array)
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

        public static int[,] ArraySumm1(int[,] array1, int[,] array2)
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

        public static int[,] ArraySumm2(int[,] array1, int[,] array2)
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

        public static int[,] ArraySumm3(int[,] array1, int[,] array2)
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
    }
}
