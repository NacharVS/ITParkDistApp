using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = i;
                while(a > 0)
                {
                    if(a % 10 == 7)
                    {
                        sum++;
                    }
                    a = a / 10;
                }
            }
            Console.WriteLine(sum);
            // input 20  output 2
            // input 100 output 20
        }
        // Сократить количество комбинаций, хотя бы в 2 раза. 

        // Ввывести представление числа N в виде простых множителей. 
        // input 6 output 2 3 
        // intput 30 output 2 3 5
        // input 16 output 2 2 2 2

        // Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет
        // наибольшей среди всей последовательности. Вывести само число и его сумму цифр
        // input 20 output 19 10
        // input 44 output 39 12

    }
}
