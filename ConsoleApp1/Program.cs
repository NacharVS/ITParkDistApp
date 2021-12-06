using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put Ur money in terminal");
            int moneyCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Products:");
            Console.WriteLine("1. Bread - 50");
            Console.WriteLine("2. Milk - 40");
            Console.WriteLine("3. Butter - 70");
            Console.WriteLine("4. Chocolate - 110");
            Console.WriteLine("5. Coffee - 100");
            Console.Write("Enter the number of product:");
            int productNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the count of product:");
            int productCount = int.Parse(Console.ReadLine());

            switch (productNumber)
            {
                case 1: if(moneyCount < productCount * 50)
                        Console.WriteLine("Not enouth money");
                else
                        Console.WriteLine($"U have bought {productCount} of bread with {productCount * 50} price, Urchange {moneyCount - productCount * 50}");
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
            //Max distance in foot/meters is MAX
        }
    }
}
