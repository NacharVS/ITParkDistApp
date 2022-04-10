using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayOperations
    {
        public static void ArrayAddition(int[] arr1, int[] arr2, int []res)
        {
            Thread.Sleep(1000);
            for (int i = 0; i < arr1.Length; i++)
            {
                res[i] = arr1[i] + arr2[i];
                Console.WriteLine(res[i]);
            }
        }
        public static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10,50);

                Console.Write(array[i] + " ");
            }
            
        }

        public static void ArrayGeneration(int[] array, int minValue, int maxValue)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);

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

                    mass[i, j] = rnd.Next(2);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayGeneration(int[,] mass, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(maxValue);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
