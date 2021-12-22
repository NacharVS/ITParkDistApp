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
            Lesson5Practice.NonSquareArraysAddition();
           
            //6 лекция. Sorting
            /*int[] array = new int[10];
            int[,] array1 = new int[10, 5];
            ArrayOperations.ArrayGeneration(array1, 20);
            Console.WriteLine();
            ArrayOperations.ArrayGeneration(array, -100, 100);*/
            /*int[] array=new int[10];
            ArrayOperations.ArrayGeneration(array, 100, 200);
            ArraySorting(array);*/
            //ShopHomeWork.Shop();
            /*Student.colledgeName = "IT Academy 2022";
            
            Student std1=new Student();
            std1.name = "Ivan";
            std1.age = 22;
            //Console.WriteLine(Student.colledgeName);

            Student std2 = new Student();
            std2.name = "Maria";
            std2.age = 20;

            std1.Studing();
            std2.Studing();*/

            // 1 2 3 - 6    1 3 2 (сортировка номеров строк от минимальной суммы)
            // 4 4 6 - 14
            // 7 1 2 - 10

            /*int[,] array = new int [10, 10];
            ArrayOperations.ArrayGeneration(array);
            SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                summIDs[i] = new SummID();

            }*/
            // 1. Отсортировать номера строк по возрастанию сумм в каждой строке матрицы.
            // 2. Переделать магазин через классы.
            // 3. Все задания выполняем в отдельных файлах.

        }
        static void Multiplicationtable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        
        static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
        static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
        static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }
        static void ArraySorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buff = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buff;
                    }
                }
            }
        }
        static void ArraySortingDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int buff = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buff;
                    }
                    else
                    {
                        ArraySorting(array);
            }
                }
            }
        }
        
    }
}
