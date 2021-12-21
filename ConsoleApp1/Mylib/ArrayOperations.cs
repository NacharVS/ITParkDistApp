using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayOperations
    {
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
    
        static void ArraySorting(int[] array)
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

        static void PrintArray(int[,] array)
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


    }
}
