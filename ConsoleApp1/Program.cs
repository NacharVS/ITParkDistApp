using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

       
        static void Main(string[] args)
        {
           
            //Сложить пересечение матриц.
            //вывести только пересечение

            int a = int.Parse(Console.ReadLine());   //2
            int b = int.Parse(Console.ReadLine());   //5
            int c= int.Parse(Console.ReadLine());    //3
            int [,] array = new int [a, b];           
            int [,] array2 = new int [b, c];          
            Random rnd = new();
            Random rnd2 = new();

            Method.ArrayGeneration(array);
            Console.WriteLine();
            
            Method.ArrayGeneration(array2);
            Console.WriteLine();

            int[,] summs = new int[a, c];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    summs[i,j] = array[i, j]+ array2[i, j];
                    Console.Write($"{summs[i,j]} ");
                }
                Console.WriteLine();
            }
            








        }


    }

}
  

   
    

