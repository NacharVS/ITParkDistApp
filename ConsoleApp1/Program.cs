using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            switch (s)
            {
                case "Winter": Console.WriteLine("december january febraury");
                    break;
                case "Summer":
                    Console.WriteLine("junio julio agosto");
                    break;
                case "Autumn":
                    Console.WriteLine("september october november");
                    break;
                case "Spring":
                    Console.WriteLine("march april may");
                    break;
                default: Console.WriteLine("incorract input");
                    break;
            }
        }
    }
}
