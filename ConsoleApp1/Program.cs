using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the first number:");
                int number_1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number:");
                int number_2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the third number:");
                int number_3 = int.Parse(Console.ReadLine());

                int average_number = -1;

                if ((number_1 > number_2 || number_1 > number_3) && (number_1 < number_2 || number_1 < number_3)) average_number = number_1;

                if ((number_2 > number_1 || number_2 > number_3) && (number_2 < number_1 || number_2 < number_3)) average_number = number_2;

                if ((number_3 > number_1 || number_3 > number_2) && (number_3 < number_1 || number_3 < number_2)) average_number = number_3;

                if (average_number != -1) Console.WriteLine($"Average number is: {average_number}");

                else Console.WriteLine("Error");
            }
        }
    }
}
