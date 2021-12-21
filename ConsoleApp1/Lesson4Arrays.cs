using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson4Arrays
    {
        public static void ArrayLength() //Длина массива+запись значений в массив
        {
            int[] array = new int[5];
            int[] array2 = new int[9];
            Console.WriteLine(array2.Length);
            array[0] = 15;
            array2[0] = 77;
            Console.WriteLine($"{array[0]} {array2[0]} {array2[1]}");
            //простая формула: [] - кол-во элементов массива. [9] - 9 элементов, но последний 8, т.к. начало с нуля.
            //macIndex=Length-1
        }
        public static void RandomClass()//класс random. Заполнение массива рандомом.
        {
            int[] array = new int[10];
            Random random = new Random();
            array[0] = random.Next(100);//одно значение в скобке - от 1 до этого значения. 2 цифры через запятую - от первой до второй.
            Console.WriteLine(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
        }
        public static void MaxMinInArray()//заполнение массива и подсчет суммы элементов. Нахождение max/min.
        {
            int[] array = new int[10];
            Random random = new Random();
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                sum += array[i];
                Console.Write($"{array[i]} ");
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма: {sum}, max: {max}, min: {min}");
        }
        public static void MoreThenPreviousInArray() //поиск элементов больше предыдущего
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.Write("Больше предыдущего: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] > array[i])
                    Console.Write($"{array[i + 1]} ");
            }
        }
        public static void PrintArrayWithForeach()//цикл foreach - только для чтения.
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            foreach (int item in array)//item - переменная, может быть любая.
            {
                Console.WriteLine(item);
            }
        }
        /*Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(array[5]);*/
        //8 2  4 65 2 3 77 8
        //4 65 3 77
        public static void ArraySorting() //Сортировка массива. Пузырьковый метод.
        {
            int[] array = new int[10];
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
        public static void TwoDimensionalArray()//двумерные массивы
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void ArrayElementsSum() //найти сумму элементов строк
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine();
            }
        }
        public static void RowSumAndSorting() //Найти сумму строки и отсортировать суммы
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd = new Random();
            int[] sumInRow = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(2);
                    sumInRow[i] += array[i, j];
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sumInRow.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sumInRow[i]}");
            }
            for (int j = 0; j < sumInRow.Length - 1; j++)
            {
                for (int i = 0; i < sumInRow.Length - 1 - j; i++)
                {
                    if (sumInRow[i] > sumInRow[i + 1])
                    {
                        int p = sumInRow[i + 1];
                        sumInRow[i + 1] = sumInRow[i];
                        sumInRow[i] = p;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sorted: ");
            foreach (var item in sumInRow)
            {
                Console.Write($"{item} ");
            }
        }
        public static void ListTheory()//ЛИСТЫ
        {
            List<int> list = new List<int>(); //объявление списка
            list.Add(5); //добавление элемента в 5й индекс списка
            list.Add(323);
            list.Add(2);
            list.Add(432);
            list.Add(342);
            list.Add(6556);
            list.Add(222);
            list.Add(43);
            if (list.Contains(222)) //содержит ли список "222"
                Console.WriteLine(list.IndexOf(222)); // узнаем индекс "222" в списке
            foreach (int item in list)
            {
                Console.WriteLine(item); //печать списка
            }
            Console.WriteLine(list[1]); //печать элемента 1го индекса списка
            Console.WriteLine(list.Count); //вывод кол-ва элементов списка
            Console.WriteLine(list.IndexOf(43));
            list.Remove(2);//удаление элемента списка из 2го индекса
        }
        /*
        Задание: в задачке про каталог товаров - создать каталог (наименование и цена за единицу).
        Должна быть возможность добавления новых товаров.
        Покупка нескольких товаров и удаление (админ).
        После сессии админа - войти под админом или клиентом. Если клиент - список товаров обновлен. (ввод товара хоть
        цифра, хоть строка) (ввод наименования и количества товаров) 
        Организовать подсчет общей стоимости покупки, проверку на наличие достаточной
        суммы денег. Если покупка прошла - вывести полный список купленных товаров и их стоимость.
        Корзина покупок - список
        Проверка денег - ифы
        Работа между переключениями админ/клиент - свич.
        Покупка - может быть 1 товар или несколько.
        */
    }
}
