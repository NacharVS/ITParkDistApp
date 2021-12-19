using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayGenerations
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

        public static void ArrayGeneration(int[,] mass)
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

        public static void ArrayGeneration(int[] array, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n);

                Console.Write(array[i] + " ");
            }
        }

        public static void ArrayGeneration(int[,] mass, int n)
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

        public static void ArrayGeneration(int[] array, int n, int m)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(n, m);

                Console.Write(array[i] + " ");
            }
        }

        public static void ArrayGeneration(int[,] mass, int n, int m)
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
    }
}
