using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            //1. Сократить количество комбинаций, хотя бы в 2 раза. См. коммит "combinations" от 9.12.2021 21:01
            Console.WriteLine("Enter summ of numbers");
            int sum = int.Parse(Console.ReadLine());
            int combination = 0;
            int countI = 0;
            int countJ = 0;
            int countK = 0;
            if (sum >= 3 && sum <= 24)
            {
                
                for (int i = 0; i <= 9; i++)
                {
                    if (i != countI && countJ != i && countK != i )
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            for (int k = 0; k <= 9; k++)
                            {
                                if (sum == i + j + k && i != j && j != k && k != i)
                                {
                                    countI = i;
                                    countJ = j;
                                    countK = k;
                                    Console.WriteLine($"{i}{j}{k}");
                                    combination++;
                                    if (i < 9)
                                        i++;
                                    if (j < 9)
                                        j++;
                                    if (k < 9)
                                        k++;



                                }
                            }
                        }
                    }
                    
                }
                Console.WriteLine($"count is {combination}");

            }
            else
            {
                Console.WriteLine("incorect. please re-enter");

            }


            //2.Ввывести представление числа N в виде простых множителей. // input 6 output 2 3 // intput 30 output 2 3 5 // input 16 output 2 2 2 2
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; number % 2 == 0; number /= 2)
            {
                Console.WriteLine('2');
            }
            for (int i = 3; i <= number;)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{i}");
                    number /= i;
                }
                else
                {
                    i += 2;
                }

            }

            //3.Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет // наибольшей среди всей последовательности. Вывести само число и его сумму цифр // input 20 output 19 10 // input 44 output 39 12

            Console.WriteLine("Enter the last number in the sequence");
            int sequen = Convert.ToInt32(Console.ReadLine());
            int MaxSum = 0;
            int Numberofmaxsum = 0;
            for (int i = 1; i < sequen; i++)
            {
                int numofSequence = i;
                int sumofnum = 0;
                for (int a = numofSequence; a > 0; a = a / 10)
                {
                    sumofnum += numofSequence % 10;
                    numofSequence = numofSequence / 10;

                }
                if (sumofnum > MaxSum)
                {
                    MaxSum = sumofnum;
                    Numberofmaxsum = i;
                }

            }
            Console.WriteLine($"In the range ( 1 - {sequen}) number {Numberofmaxsum} has maximum sum of digits {MaxSum}");


        }
    }
}
