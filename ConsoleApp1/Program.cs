using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Summ(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }

        static int Summ1( int a, int b)
        {
            return a + b;

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

        static void ArrayGeneration2()
        {
            Random rnd = new Random();
            int[,] mass = new int[10,10];
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
            int[] mass = new int[10];
            ArrayGeneration(mass);
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"element {index} {mass[index-1]}");
        
           
          
        }
        

    }
}
