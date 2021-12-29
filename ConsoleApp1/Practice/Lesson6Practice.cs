using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson6Practice
    {
        public static void MyVariant()
        {
            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);
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
        public static void ArrayRowSumAndSorting()
        {
            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix, 100);

            SummID[] summIDs = new SummID[10];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                summIDs[i] = new SummID();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    summIDs[i].rowId = i;
                    summIDs[i].summInCurrentRow += matrix[i, j];
                }
            }
            Console.WriteLine();
            foreach (var item in summIDs)
            {
                Console.WriteLine($"{item.rowId + 1} - {item.summInCurrentRow}");
            }

            for (int i = 0; i < summIDs.Length - 1; i++)
            {
                for (int j = 0; j < summIDs.Length - 1 - i; j++)
                {
                    int buff1 = 0;
                    int buff2 = 0;
                    if (summIDs[j].summInCurrentRow > summIDs[j + 1].summInCurrentRow)
                    {
                        buff1 = summIDs[j].rowId;
                        buff2 = summIDs[j].summInCurrentRow;
                        summIDs[j].summInCurrentRow = summIDs[j + 1].summInCurrentRow;
                        summIDs[j].rowId = summIDs[j + 1].rowId;
                        summIDs[j + 1].summInCurrentRow = buff2;
                        summIDs[j + 1].rowId = buff1;

                    }

                }
            }
            Console.WriteLine();
            foreach (var item in summIDs)
            {
                Console.WriteLine($"{item.rowId + 1} - {item.summInCurrentRow}");
            }
        }
    }
}
