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
            
        }
    }
}
