using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson6Methods2
    {
        //6 лекция. Sorting
        /*
        Summ(7, 7, 7, 7, 7, 7); //перегрузки метода Summ
        Summ(7, 7, 7, 3);
        Summ(7);
        Summ("5","7");
        Summ(0.1,0.1);
        Summ(5000000,1);
        Summ(7,7,7,7,7,7,7,7,7);
        int[] array = new int[10];
        int[,] array1 = new int[10, 5];
        ArrayOperations.ArrayGeneration(array1, 20);
        ArrayOperations.ArrayGeneration(array1, 5, 100);
        int[] array = new int[10];
        Lesson6Methods2.ArraySorting(array); //сортировка по возрастанию
        Console.WriteLine();
        Lesson6Methods2.ArraySorting(array,"desc"); //обратная сортировка массива моя, с перегрузкой по стрингу "desc"
        Console.WriteLine();
        Lesson6Methods2.ArraySorting(array, true); //обратняа сортировка массива от Вадима с булевой переменной
        Console.WriteLine();
        ArrayOperations.ArrayGeneration(array, -100, 100);
        int[] array=new int[10];
        ArrayOperations.ArrayGeneration(array, 100, 200);
        ArraySorting(array);
        //ShopHomeWork.Shop();
        Student.colledgeName = "IT Academy 2022";

        Student std1=new Student();
        std1.name = "Ivan";
        std1.age = 22;
        //Console.WriteLine(Student.colledgeName);

        Student std2 = new Student();
        std2.name = "Maria";
        std2.age = 20;

        std1.Studing();
        std2.Studing();

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
        public static void MultiplicationTable() //таблица умножения
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        static void Summ(int a, int b) //суммы с перегрузками
        {
            Console.WriteLine($"summ int {a + b}");
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
        public static void ArraySorting(int[] array) //сортировка массива по возрастанию
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int p = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = p;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
        public static void ArraySorting(int[] array, string descOption) //сортировка массива по убыванию
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int p = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = p;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
        public static void ArraySorting(int[] array, bool flag) //сортировка массива по убыванию от Вадима
        {
            if (flag)
            {
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(10, 100);
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1 - j; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int p = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = p;
                        }
                    }
                }
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
            }
            else ArraySorting(array);
        }
    }
}