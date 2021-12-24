using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayMethods
    {

        public static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);

                Console.Write(array[i] + " ");
            }
        }



        public static void ArrayGeneration2(int[,] mass)
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
        public static void ArrayGeneration2(int rows, int columns, int[,] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    mass[i, j] = rnd.Next(100);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }                                                                   
        }

        public static void ArraySorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {

                }
            }
        }
    }
}
