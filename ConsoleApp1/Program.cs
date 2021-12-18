using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

             int[,] array1 = new int [2, 5];
             Random rnd = new();
             int[,] array2 = new int[5, 3];
             Random rnd2 = new();



             for (int i = 0; i < array1.GetLength(0); i++)
             {
                 for (int j = 0; j < array1.GetLength(1); j++)
                 {
                     array1[i, j] = rnd.Next(0,10);
                     Console.Write($"{array1[i,j]} ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();



             for (int i = 0; i < array2.GetLength(0); i++)
             {
                 for (int j = 0; j < array2.GetLength(1); j++)
                 {
                     array2[i, j] = rnd2.Next(0, 10);
                     Console.Write($"{array2[i, j]} ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();

             


             int[,] array3 = new int[2, 3];
             for (int i = 0; i < array3.GetLength(0); i++)
             {
                 for (int j = 0; j < array3.GetLength(1); j++)
                 {
                     array3[i, j] = array1[i, j] + array2[i, j];
                     Console.Write($"{array3[i, j]} ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
            
            




        }
           
            
     }

}
  

   
    

