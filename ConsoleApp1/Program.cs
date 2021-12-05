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
                case "winter": Console.WriteLine("december january febraury");
                    break;
                case "summer":
                    Console.WriteLine("junio julio agosto");
                    break;
                case "autumn":
                    Console.WriteLine("september october november");
                    break;
                case "spring":
                    Console.WriteLine("march april may");
                    break;
                default: Console.WriteLine("incorract input");
                    break;
            }
        }
    }
}
