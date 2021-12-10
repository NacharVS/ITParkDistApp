using System;

namespace ConsoleApp1
{
    // Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет
    // наибольшей среди всей последовательности. Вывести само число и его сумму цифр
    // input 20 output 19 10
    // input 44 output 39 12
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number N;");
            int n = int.Parse(Console.ReadLine());
            
            int maxNumber = 0;
            int maxSumm = 0;

            //Iterate through all digits of the sequence.
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int summ = 0;

                //Finding the sum of the digits of the number i from the sequence.
                while (number > 0)
                {
                    summ = summ + number % 10;
                    number = number / 10;
                }

                if (maxSumm < summ)
                {
                    maxSumm = summ;
                    maxNumber = i;
                }
            }

            Console.WriteLine($"The number: {maxNumber} has the largest sum of digits: {maxSumm} among all the numbers in the sequence from 1 to {n}");
        }
    }
}
