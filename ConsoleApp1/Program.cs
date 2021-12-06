using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter a three-digit number:");
                int number = int.Parse(Console.ReadLine());

                if (number > 99 && number < 1000)
                {
                    int even_odd = number % 2;
                    int units = number % 10;
                    int dozens = (number / 10) % 10;
                    int hundreds = number / 100;

                    int result;

                    switch (even_odd)
                    {
                        case 0:
                            result = hundreds + dozens + units;
                            Console.WriteLine($"The sum of three numbers is: {result}");
                            break;

                        case 1:
                            result = hundreds * dozens * units;
                            Console.WriteLine($"Multiplication of three numbers is: {result}");
                            break;

                        default:
                            Console.WriteLine("Error");
                            break;
                    }

                }

                else Console.WriteLine("You entered the wrong number!");

            }
        }
    }
}
