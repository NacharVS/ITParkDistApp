using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);

            SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                summIDs[i] = new SummID();             
            }

            // 1. Отсортировать номера строк по возрастанию сумм в кажджой строке матрицы.
            // 2. Переделать Магазин из ДЗ2 через классы. 
            // * Все задания выполняем отдельных файлах


        }
        // 1 2 3 - 6      1 3 2
        // 4 4 6 - 14
        // 7 1 2 - 10


    }
}
