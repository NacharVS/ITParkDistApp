using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a three digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 99 && number < 1000)
            {
                double number1 = number / 2 % 1;
                if (number1 == 0)
                {
                    int one = number % 10;
                    int two = number / 10 % 10;
                    int three = number / 100;
                    Console.WriteLine(one + two + three);
                }
                else
                {
                    int one = number % 10;
                    int two = number / 10 % 10;
                    int three = number / 100;
                    Console.WriteLine(one * two * three);
                }
            }
            else
            {
                Console.WriteLine("incorrect data");
            }
        }
    }
}
