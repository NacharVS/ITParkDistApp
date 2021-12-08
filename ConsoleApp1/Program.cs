using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Request data about the deposit and the number of months.
                Console.WriteLine("Enter the deposit amount:");
                double depositAtBeginning = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of months of deposit storage:");
                int numberOfmonth = int.Parse(Console.ReadLine());

                double depositAtEnd;

                if (depositAtBeginning <= 0 && numberOfmonth <= 0)

                    if (depositAtBeginning <= 0)

                        Console.WriteLine("You have entered a negative deposit!");

                    if (numberOfmonth <= 0)

                        Console.WriteLine("You entered a negative number of months!");
   
                else
                {
                    depositAtEnd = depositAtBeginning * Math.Pow(1 + 0.04, numberOfmonth);
                    Console.WriteLine($"The amount of the deposit after {numberOfmonth} months will become {depositAtEnd}");
                }

            }
        }
    }
}
