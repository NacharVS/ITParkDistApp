using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            // поиск элементов которые больше чем предыдущий
            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i+1] > array[i])
                    Console.Write($" {array[i + 1]}");
            }


        }
        
    }
}
