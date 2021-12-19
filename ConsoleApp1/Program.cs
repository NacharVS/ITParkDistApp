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
                    Console.WriteLine($"{i} * {j} = {i*j}");
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
                array[i] = rnd.Next(100);

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

                    mass[i, j] = rnd.Next(100);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] array = new int[10,5];
            ArrayGeneration(array);
            // 4 6 8 9 2          
            // 2 1 5 7 3

            // 1 1 2 
            // 7 8 9
            // 3 1 2
            // 1 1 1
            // 6 5 8

            // 5 7 10
            // 9 9 14


            // 5 7 10 9 2
            // 9 9 14 7 3
            // 3 1 2 0 0
            // 1 1 1 0 0
            // 6 5 8 0 0 

        }
        

    }
}
