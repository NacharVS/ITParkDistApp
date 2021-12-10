using System;

namespace ConsoleApp1
{
    // Ввывести представление числа N в виде простых множителей. 
    // input 6 output 2 3 
    // intput 30 output 2 3 5
    // input 16 output 2 2 2 2
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number N;");
            int number = int.Parse(Console.ReadLine());
                        
            while (number > 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        number = number / i;
                        
                        Console.Write($"{i} ");
                        break;
                    }
                }
            }

        }
        

        // Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет
        // наибольшей среди всей последовательности. Вывести само число и его сумму цифр
        // input 20 output 19 10
        // input 44 output 39 12

    }
}
