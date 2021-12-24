using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Method
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

        public static void ArrayGeneration(int[,] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0,10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
           
        }
        public static void ArrayGeneration(int[] array, int minValue, int maxValue)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[i] = rnd.Next(minValue, maxValue);
                    Console.Write(array[i] + " ");
                }
            }
        }

        public static void ArraySorting(int[] array)
        {
            ArrayGeneration(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }

                }
            }
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }

        }

       public static void ArraySorting(int[] array, bool flag)
        {
            if (flag)
            {

                ArrayGeneration(array);

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int buffer = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = buffer;
                        }

                    }
                }
                Console.WriteLine();
                foreach (var item in array)
                {
                    Console.WriteLine($"{item} ");
                }
            }
            else
            {
                ArraySorting(array);
            }
        }


       public static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }

       public static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
       public static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
       public static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }

       public static void Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }
            Console.WriteLine(summ);
        }

        public static void SummMas(int [] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        public static void SummMas(int[,] array1, int[,] array2)
        {


        }
            public static void MultiplicationTable()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j} ");
                }
                Console.WriteLine();
            }
        }





    }

}
    



