using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson5Practice
    {
        public static void NonSquareArraysAddition() //складываение НЕквадратных матриц
        {
            //задча. берем 2 массива одномерных. 3*6 и 8*3.
            // сложить потовряющие индексы в массиве
            // 4 6 8 9 2
            // 2 1 5 7 3

            // 1 1 2
            // 7 8 9
            // 3 1 2
            // 1 1 1
            // 6 5 8

            // 5 7 10
            // 9 9 14

            // 5 7 10 9 2
            // 9 9 14 7 3
            // 3 1 2 0 0
            // 1 1 1 0 0 
            // 6 5 8 0 0

            Console.WriteLine("Матрица А");
            Console.Write("Строк: ");
            int aRow = int.Parse(Console.ReadLine());
            Console.Write("Столбцов: ");
            int aColumn = int.Parse(Console.ReadLine());
            Console.WriteLine("Матрица B");
            Console.Write("Строк: ");
            int bRow = int.Parse(Console.ReadLine());
            Console.Write("Столбцов: ");
            int bColumn = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] arrayA = new int[aRow, aColumn];
            int[,] arrayB = new int[bRow, bColumn];
            Console.WriteLine("Матрица A:");
            ArrayOperations.ArrayGeneration(arrayA, 1, 4);//заполняем рандом (1-4) в массив A и печатаем
            Console.WriteLine("Матрица B:");
            ArrayOperations.ArrayGeneration(arrayB, 1, 4);//заполняем рандом (1-4) в массив B и печатаем
            string outputOption = "0";
            while (outputOption != "в")
            {
                Console.WriteLine();
                Console.Write("Вывести сумму пересечения матрицы(1),всей матрицы(2) или выйти(в)?: ");
                outputOption = Console.ReadLine();
                switch (outputOption)
                {
                    case "1"://вывод суммы матриц А,Б по индексам пересечений
                        {
                            int minRow = Math.Min(aRow, bRow);
                            int minColumn = Math.Min(aColumn, bColumn);
                            int[,] arrayAddition = new int[minRow, minColumn];
                            for (int i = 0; i < minRow; i++)
                            {
                                for (int j = 0; j < minColumn; j++)
                                {
                                    arrayAddition[i, j] = arrayA[i, j] + arrayB[i, j];//складываем массивы до минимальных индексов строк/столбцов
                                }
                            }
                            Console.WriteLine("Сумма пересечений матриц А,В:");
                            ArrayOperations.ArrayPrint(arrayAddition);//печать суммы матриц
                        }
                        break;
                    case "2"://вывод суммы матриц А,В по всем индексам
                        {
                            if (aRow >= bRow & aColumn >= bColumn)
                            {
                                int[,] arrayAddition = new int[aRow, aColumn];
                                for (int i = 0; i < aRow; i++)
                                {
                                    for (int j = 0; j < aColumn; j++)
                                    {
                                        if (i < bRow & j < bColumn) arrayAddition[i, j] = arrayA[i, j] + arrayB[i, j];//складываем массивы до размерности меньшего
                                        else arrayAddition[i, j] = arrayA[i, j];//остальное просто копируем в новый массив
                                    }
                                }
                                Console.WriteLine("Сумма матриц A+B:");
                                ArrayOperations.ArrayPrint(arrayAddition);//печать суммы матриц
                            }
                            else if (aRow <= bRow & aColumn <= bColumn)
                            {
                                int[,] arrayAddition = new int[bRow, bColumn];
                                for (int i = 0; i < bRow; i++)
                                {
                                    for (int j = 0; j < bColumn; j++)
                                    {
                                        if (i < aRow & j < aColumn) arrayAddition[i, j] = arrayA[i, j] + arrayB[i, j];//складываем массивы до размерности меньшего
                                        else arrayAddition[i, j] = arrayB[i, j];//остальное просто копируем в новый массив
                                    }
                                }
                                Console.WriteLine("Сумма матриц A+B:");
                                ArrayOperations.ArrayPrint(arrayAddition);//печать суммы матриц
                            }
                            else if (aRow >= bRow & aColumn <= bColumn)
                            {
                                int[,] arrayAddition = new int[aRow, bColumn];
                                for (int i = 0; i < aRow; i++)
                                {
                                    for (int j = 0; j < bColumn; j++)
                                    {
                                        if (i < bRow & j < aColumn)
                                        {
                                            arrayAddition[i, j] = arrayA[i, j] + arrayB[i, j];//складываем индексы пересечений матриц А,В
                                        }
                                        else if (i >= bRow & j < aColumn)
                                        {
                                            arrayAddition[i, j] = arrayA[i, j];//определяем, что взять из матрицы А без изменений
                                        }
                                        else if (i < bRow & j >= aColumn)
                                        {
                                            arrayAddition[i, j] = arrayB[i, j];//определяем, что взять из матрицы В без изменений
                                        }//в незаполненных индексах arrayAddition будут нули
                                    }
                                }
                                Console.WriteLine("Сумма матриц A+B:");
                                ArrayOperations.ArrayPrint(arrayAddition);//печать суммы матриц
                            }
                            else if (aRow <= bRow & aColumn >= bColumn)
                            {
                                int[,] arrayAddition = new int[bRow, aColumn];
                                for (int i = 0; i < bRow; i++)
                                {
                                    for (int j = 0; j < aColumn; j++)
                                    {
                                        if (i < aRow & j < bColumn)
                                        {
                                            arrayAddition[i, j] = arrayA[i, j] + arrayB[i, j];//складываем индексы пересечений матриц А,В
                                        }
                                        else if (i < aRow & j >= bColumn)
                                        {
                                            arrayAddition[i, j] = arrayA[i, j];//определяем, что взять из матрицы А без изменений
                                        }
                                        else if (i >= aRow & j < bColumn)
                                        {
                                            arrayAddition[i, j] = arrayB[i, j];//определяем, что взять из матрицы В без изменений
                                        }
                                    }
                                }
                                Console.WriteLine("Сумма матриц A+B:");
                                ArrayOperations.ArrayPrint(arrayAddition);//печать суммы матриц
                            }
                        }
                        break;
                    case "в"://выходим из программы
                        {
                            outputOption = "в";
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: только '1' , '2' или 'в'!");//проверка на ввод неверных значений
                        break;
                }
            }
        }
    }
}
