using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayOperations
    {
        //генерация матрицы
        public static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);

                Console.Write(array[i] + " ");
            }
        }
        //генерация массива с перегрузкой по мин.-макс. рандому
        public static void ArrayGeneration(int[] array, int minValue, int maxValue)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);

                Console.Write(array[i] + " ");
            }
        }
        //генерация матрицы без перегрузок
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
        //генерация матрицы с перегрузкой максимального рандома
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
        //генерация матрицы с перегрузкой по мин.-макс. рандому
        public static void ArrayGeneration(int[,] mass, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(minValue, maxValue);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //печать матрицы
        public static void ArrayPrint (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
