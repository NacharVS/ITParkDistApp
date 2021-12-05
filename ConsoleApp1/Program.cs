using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double footDistance = double.Parse(Console.ReadLine()); //0.305 metr
            //double metrDistance = double.Parse(Console.ReadLine());
            /*
            Console.WriteLine( "enter Speed meter/sec");
            double msSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("enter Speed km/h");
            double kmhSpeed = double.Parse(Console.ReadLine()); // *1000/3600
            
            if (msSpeed > kmhSpeed * 1000 / 3600)
            {
                Console.WriteLine ( $"max Speed is:{msSpeed}  meter/sec");
            }
            else
            {
                Console.WriteLine($"max Speed is:{kmhSpeed}  km/h");
            }
            */

            /*
            string s = Console.ReadLine();
            s = s.ToLower();
            switch (s)
            {
                case "monday": Console.WriteLine(1);
                    break;
                case "tuesday": Console.WriteLine(2);
                    break;
                case "wednesday": Console.WriteLine(3);
                    break;
                case "thursday": Console.WriteLine(4);
                    break;
                default : Console.WriteLine("incorrect input");
                    break;
            }
            */
            /*
            Console.WriteLine("enter season ");
            string season = Console.ReadLine();
            season = season.ToLower();
            switch (season)
            {
                case "spring": Console.WriteLine(" - March, Aprile, May");
                    break;
                case "summer": Console.WriteLine(" - June, July, August");
                    break;
                case "autumn": Console.WriteLine(" - September, October, November");
                    break;
                case "winter": Console.WriteLine(" - December, January, February");
                    break;
                default : Console.WriteLine("incorrect input");
                    break;
            }
            */

            Console.WriteLine("Please enter how macth money you want to spend ");
            double money = double.Parse ( Console.ReadLine() );
            
            Console.WriteLine("Sugar = 1$, bread = 2$, butter = 3$, coffee = 4$");
            Console.WriteLine("Choose some food");
            string food = Console.ReadLine();
            food = food.ToLower();
            
            Console.WriteLine("How match food you want to buy?");
            double howMatch = double.Parse(Console.ReadLine());
            
            switch (food)
            {
                case "sugar":
                    if (1 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} kg of sugar. It costs {1 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "bread":
                    if (2 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} bars of bread. It costs {2 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "butter":
                    if (3 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} bars of butter. It costs {3 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "coffee":
                    if (4 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} g of coffe. It costs {4 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }

        }
    }
}
