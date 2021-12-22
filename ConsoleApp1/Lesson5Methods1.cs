using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson5Methods1
    {
        // Задание, для тех, кто сделал магазин:
        // cложить 2 матрицы разного размера
        // 1 меньше чем вторая матрица (2 мерный массив), сложить их. Матрицы могут быть одна больше или другая.
        // Сначала найти какая больше матрица.
        public static void SquareArraysAddition() //складывание квадратных матриц
        {
            Console.WriteLine("Введите размерность массива A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размерность массива B:");
            int b = int.Parse(Console.ReadLine());
            int[,] array1 = new int[a, a];
            int[,] array2 = new int[b, b];
            Random rnd = new Random();
            Console.WriteLine("Массив A:");
            //заполняем рандом в массив A
            for (int i = 0; i < array1.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во столбцов.
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rnd.Next(4);
                    Console.Write($"{array1[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив B:");
            //заполняем рандом в массив B
            for (int i = 0; i < array2.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во столбцов.
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rnd.Next(4);
                    Console.Write($"{array2[i, j]} ");
                }
                Console.WriteLine();
            }
            //проверяем какой массив меньше
            if (a < b)
            {
                int[,] array3 = new int[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (i < a && j < a) array3[i, j] = array1[i, j] + array2[i, j];//складываем массивы до размерности меньшего A
                        else array3[i, j] = array2[i, j];//остальное просто копируем в новый массив
                    }

                }
                //выводим сумму массивов
                Console.WriteLine("Массив A+B:");
                for (int i = 0; i < array3.GetLength(0); i++)
                {
                    for (int j = 0; j < array3.GetLength(1); j++)
                    {
                        Console.Write($"{array3[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                int[,] array3 = new int[a, a];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i < b && j < b) array3[i, j] = array1[i, j] + array2[i, j];//складываем массивы до размерности меньшего B
                        else array3[i, j] = array1[i, j];//остальное просто копируем в новый массив
                    }

                }
                //выводим сумму массивов
                Console.WriteLine("Массив A+B:");
                for (int i = 0; i < array3.GetLength(0); i++)
                {
                    for (int j = 0; j < array3.GetLength(1); j++)
                    {
                        Console.Write($"{array3[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // 2 9
        // 3 7

        // 1 2 3 4
        // 8 7 5 2
        // 3 4 6 7
        // 6 3 7 4

        //5 лекция. Методы

        /*ArrayGeneration();
        Console.WriteLine();
        Console.WriteLine();
        ArrayGeneration2();*/

        /*Summ(int.Parse("5"),3);
        Summ(int.Parse(Console.ReadLine()), 3);*/

        //string - ссылочный тип.
        //Все остальное - значимые типы (цифры+char). Хранятся в Стеке - там хранится ссылка на строку,
        //а сама строка в другом месте ...
        //входящим параметром метод не оперирует - передается только его копия.
        //чтобы оперировать параметром - указывается перед параметром ref

        /*int x = 5;
        Summ(ref x, 6);
        Console.WriteLine(x);
        Console.WriteLine(Summ1(5, 6));*/

        //массив всегда передается в метод по ссылке

        /*int[] mass = new int[10];
        ArrayGeneration(mass);
        Console.WriteLine();
        Console.WriteLine($"element 6 {mass[5]}");
        int[,] mass = new int[7,7];
        ArrayGeneration2(mass);
        Console.WriteLine();
        Console.Write("index?:");
        int index= int.Parse(Console.ReadLine());
        Console.WriteLine();*/

        //Console.WriteLine($"element {index} {mass[index-1]}");

        // задача. берем 2 двумерных массива разных размерностей. 3*6 и 8*3.
        // сложить потовряющие индексы в массиве. (места пересечений)
        
        // 4 6 8 9 2 - 1 массив
        // 2 1 5 7 3

        // 1 1 2 - 2 массив
        // 7 8 9
        // 3 1 2
        // 1 1 1
        // 6 5 8

        // 5 7 10 - 1 задача:выводим только пересечение
        // 9 9 14

        // 5 7 10 9 2 - 2 задача: у 1й задачи выводить и остальные элементы без имзенений
        // 9 9 14 7 3
        // 3 1 2 0 0
        // 1 1 1 0 0 
        // 6 5 8 0 0
        static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();
            //int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write(array[i] + " ");
            }
        }
        static void ArrayGeneration2(int[,] mass)
        {
            Random rnd = new Random();
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
        static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }
        static void Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }
            Console.WriteLine(summ);
        }
        static void Summ(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }
        static int Summ1(int a, int b)
        {
            return a + b;
        }
    }
}