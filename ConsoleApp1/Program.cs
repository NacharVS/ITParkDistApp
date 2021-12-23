using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);

            /*SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                summIDs[i] = new SummID();
            }*/
            int[] arrayOfMatrixSumRow = new int[10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    
                }
                arrayOfMatrixSumRow[i] = sum;
            }
            Console.WriteLine("Сумма строк:");
            ArrayOperations.ArrayPrint(arrayOfMatrixSumRow);
            Console.WriteLine("Отсортированный массив сумм:");
            ArrayOperations.ArraySorting(arrayOfMatrixSumRow);
        }
    }
}
