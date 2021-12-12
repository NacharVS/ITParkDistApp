using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            int summ = 0;
            Random rnd = new Random();
            //сумма в каждой строке массива

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(2);
                    summ += array[i, j];
                    Console.Write($"{array[i,j]} ");
                }
                Console.Write($"   {summ}");
                summ = 0;
                Console.WriteLine();
            }




        }
        
    }
}
