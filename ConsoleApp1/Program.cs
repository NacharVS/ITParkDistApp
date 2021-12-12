using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            // сортировка методом пузырька
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10,100);
                Console.Write($"{array[i]} ");
            }

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1-j; i++)
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
        
    }
}
