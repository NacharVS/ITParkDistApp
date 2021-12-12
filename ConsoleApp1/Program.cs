using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////
            ////Задача 1////
            ////////////////

            //Вводим сумму
            Console.WriteLine("enter the sum of combinations");
            int summ = Convert.ToInt32(Console.ReadLine());
            int count = 0;// 1 < summ < 27

            //Создаем переменные под оригинальные не повторяющиеся значения (их максимум может быть 10)
            int combinations1 = 0;
            int combinations2 = 0;
            int combinations3 = 0;
            int combinations4 = 0;
            int combinations5 = 0;
            int combinations6 = 0;
            int combinations7 = 0;
            int combinations8 = 0;
            int combinations9 = 0;
            int combinations10 = 0;

            //Перебор всех возможных комбинаций
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {

                        if (i + j + k == summ && i != j && j != k && i != k &&
                        combinations1 != (i * 100 + j * 10 + k) && combinations1 != (i * 100 + k * 10 + j) && combinations1 != (j * 100 + i * 10 + k) && combinations1 != (j * 100 + k * 10 + i) && combinations1 != (k * 100 + i * 10 + j) && combinations1 != (k * 100 + j * 10 + i) &&
                        combinations2 != (i * 100 + j * 10 + k) && combinations2 != (i * 100 + k * 10 + j) && combinations2 != (j * 100 + i * 10 + k) && combinations2 != (j * 100 + k * 10 + i) && combinations2 != (k * 100 + i * 10 + j) && combinations2 != (k * 100 + j * 10 + i) &&
                        combinations3 != (i * 100 + j * 10 + k) && combinations3 != (i * 100 + k * 10 + j) && combinations3 != (j * 100 + i * 10 + k) && combinations3 != (j * 100 + k * 10 + i) && combinations3 != (k * 100 + i * 10 + j) && combinations3 != (k * 100 + j * 10 + i) &&
                        combinations4 != (i * 100 + j * 10 + k) && combinations4 != (i * 100 + k * 10 + j) && combinations4 != (j * 100 + i * 10 + k) && combinations4 != (j * 100 + k * 10 + i) && combinations4 != (k * 100 + i * 10 + j) && combinations4 != (k * 100 + j * 10 + i) &&
                        combinations5 != (i * 100 + j * 10 + k) && combinations5 != (i * 100 + k * 10 + j) && combinations5 != (j * 100 + i * 10 + k) && combinations5 != (j * 100 + k * 10 + i) && combinations5 != (k * 100 + i * 10 + j) && combinations5 != (k * 100 + j * 10 + i) &&
                        combinations6 != (i * 100 + j * 10 + k) && combinations6 != (i * 100 + k * 10 + j) && combinations6 != (j * 100 + i * 10 + k) && combinations6 != (j * 100 + k * 10 + i) && combinations6 != (k * 100 + i * 10 + j) && combinations6 != (k * 100 + j * 10 + i) &&
                        combinations7 != (i * 100 + j * 10 + k) && combinations7 != (i * 100 + k * 10 + j) && combinations7 != (j * 100 + i * 10 + k) && combinations7 != (j * 100 + k * 10 + i) && combinations7 != (k * 100 + i * 10 + j) && combinations7 != (k * 100 + j * 10 + i) &&
                        combinations8 != (i * 100 + j * 10 + k) && combinations8 != (i * 100 + k * 10 + j) && combinations8 != (j * 100 + i * 10 + k) && combinations8 != (j * 100 + k * 10 + i) && combinations8 != (k * 100 + i * 10 + j) && combinations8 != (k * 100 + j * 10 + i) &&
                        combinations9 != (i * 100 + j * 10 + k) && combinations9 != (i * 100 + k * 10 + j) && combinations9 != (j * 100 + i * 10 + k) && combinations9 != (j * 100 + k * 10 + i) && combinations9 != (k * 100 + i * 10 + j) && combinations9 != (k * 100 + j * 10 + i) &&
                        combinations10 != (i * 100 + j * 10 + k) && combinations10 != (i * 100 + k * 10 + j) && combinations10 != (j * 100 + i * 10 + k) && combinations10 != (j * 100 + k * 10 + i) && combinations10 != (k * 100 + i * 10 + j) && combinations10 != (k * 100 + j * 10 + i))
                        {
                            count++;

                            //Переводим комбинацию чисел i, j, k в трехзначное число
                            switch (count)
                            {
                                case 1:
                                    combinations1 = i * 100 + j * 10 + k;
                                    break;
                                case 2:
                                    combinations2 = i * 100 + j * 10 + k;
                                    break;
                                case 3:
                                    combinations3 = i * 100 + j * 10 + k;
                                    break;
                                case 4:
                                    combinations4 = i * 100 + j * 10 + k;
                                    break;
                                case 5:
                                    combinations5 = i * 100 + j * 10 + k;
                                    break;
                                case 6:
                                    combinations6 = i * 100 + j * 10 + k;
                                    break;
                                case 7:
                                    combinations7 = i * 100 + j * 10 + k;
                                    break;
                                case 8:
                                    combinations8 = i * 100 + j * 10 + k;
                                    break;
                                case 9:
                                    combinations9 = i * 100 + j * 10 + k;
                                    break;
                                case 10:
                                    combinations10 = i * 100 + j * 10 + k;
                                    break;
                            }
                            Console.WriteLine($"{i}{j}{k}");
                        }
                    }
                }
            }
            Console.WriteLine($" count {count}");

            ////////////////
            ////Задача 2////
            ////////////////

            //Console.WriteLine("enter number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int multiplier = 2;

            //// Целая часть от деления
            //int WholePart = number;


            //while (multiplier != 0)
            //{
            //    //Остаток от деления
            //    int remainderOfTheDivision = 0;

            //    remainderOfTheDivision = WholePart % 2;                           
            //    if (remainderOfTheDivision == 0)
            //    {
            //        WholePart = WholePart / 2;
            //        multiplier = 2;
            //    }
            //    else
            //        multiplier = 0;

            //    if (multiplier == 0)
            //    {
            //        remainderOfTheDivision = WholePart % 3;
            //        if (remainderOfTheDivision == 0)
            //        {
            //            WholePart = WholePart / 3;
            //            multiplier = 3;
            //        }
            //        else
            //            multiplier = 0;
            //    }

            //    if (multiplier == 0)
            //    {
            //        remainderOfTheDivision = WholePart % 5;
            //        if (remainderOfTheDivision == 0)
            //        {
            //            WholePart = WholePart / 5;
            //            multiplier = 5;
            //        }
            //        else
            //            multiplier = 0;
            //    }

            //    if (multiplier == 0)
            //    {
            //        remainderOfTheDivision = WholePart % 7;
            //        if (remainderOfTheDivision == 0)
            //        {
            //            WholePart = WholePart / 7;
            //            multiplier = 7;
            //        }
            //        else
            //            multiplier = 0;
            //    }

            //    if (multiplier == 0)
            //        Console.WriteLine($" multiplier - {WholePart}");
            //    else
            //        Console.WriteLine($" multiplier - {multiplier}");

            //    if (WholePart == 1)
            //        multiplier = 0;


            //}         

            ////////////////
            ////Задача 3////
            ////////////////

            ////вводим число
            //Console.WriteLine("enter sequence limit (max 10000)");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int value = 0;
            //int max = 1;
            //int sum = 0;
            //int needNumber = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    int number1 = 0;
            //    int number2 = 0;
            //    int number3 = 0;
            //    int number4 = 0;
            //    int number5 = 0;


            //    if (i < 10000)
            //    {
            //        if (i < 1000)
            //        {
            //            if (i < 100)
            //            {
            //                if (i < 10)
            //                {
            //                    value = 1;
            //                }
            //                else
            //                    value = 2;
            //            }
            //            else
            //                value = 3;

            //        }
            //        else
            //            value = 4;
            //    }
            //    else
            //        value = 5;


            //    switch (value)
            //    {
            //        case 1:

            //            number1 = i;
            //            sum = number1;
            //            break;

            //        case 2:
            //            number1 = i / 10;
            //            number2 = i % 10;
            //            sum = number1 + number2;
            //            break;

            //        case 3:
            //            number1 = i / 100;
            //            number2 = (i % 100) / 10;
            //            number3 = (i % 100) % 10;
            //            sum = number1 + number2 + number3;
            //            break;

            //        case 4:
            //            number1 = i / 1000;
            //            number2 = i % 1000 / 100;
            //            number3 = i % 1000 % 100 / 10;
            //            number4 = i % 1000 % 100 % 10;
            //            sum = number1 + number2 + number3 + number4;

            //            break;

            //        case 5:
            //            number1 = i / 10000;
            //            number2 = i % 10000 / 1000;
            //            number3 = i % 10000 % 1000 / 100;
            //            number4 = i % 10000 % 1000 % 100 / 10;
            //            number5 = i % 10000 % 1000 % 100 % 10;
            //            sum = number1 + number2 + number3 + number4 + number5;
            //            break;
            //    }

            //    if (sum > max)
            //    {
            //        max = sum;
            //        needNumber = i;
            //    }

            //}

            //Console.WriteLine($"Need number ---- {needNumber}");
            //Console.WriteLine($"Sum ---- {max}");         
        }
    }
}
