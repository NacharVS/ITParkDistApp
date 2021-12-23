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
        //печать массива
        public static void ArrayPrint(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
                Console.WriteLine();
            }
        }
        //печать матрицы
        public static void ArrayPrint(int[,] array)
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
        public static void ArraySorting(int[] array) //сортировка массива по возрастанию
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int p = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = p;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
                Console.WriteLine();
            }
        }
        public static void ArraySorting(int[] array, string descOption) //сортировка массива по убыванию
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int p = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = p;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
        public static void ArraySorting(int[] array, bool flag) //сортировка массива по убыванию от Вадима
        {
            if (flag)
            {
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(10, 100);
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1 - j; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int p = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = p;
                        }
                    }
                }
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
            }
            else ArraySorting(array);
        }
    }
}
