using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }
            Console.WriteLine(summ);
        }
        static void Multiplicationtable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }

        static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
        static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
        static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }

        static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 2);

                Console.Write(array[i] + " ");
            }
        }

        static void ArrayGeneration(int[,] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(0, 2);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ArrayGeneration(int[] array, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n);

                Console.Write(array[i] + " ");
            }
        }

        static void ArrayGeneration(int[,] mass, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(n);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ArrayGeneration(int[] array, int n, int m)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n, m);

                Console.Write(array[i] + " ");
            }
        }

        static void ArrayGeneration(int[,] mass, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(n, m);

                    Console.Write(mass[i, j] + " ");
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


        static void ArraySorting(int[] array, bool flag)
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

        static void Main(string[] args)
        {
            int[] array = new int[10];
            ArrayGeneration(array, 100);
            ArraySorting(array);
            ArraySorting(array, true);
            ArraySorting(array, false);

        }


    }
}
