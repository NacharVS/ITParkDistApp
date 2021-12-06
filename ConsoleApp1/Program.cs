using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 < number3)
            {
                Console.WriteLine(number1);
            }
            else if (number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 < number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }
            Console.ReadKey();
        }
    }
}
