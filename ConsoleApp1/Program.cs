using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // winter --> december, january, february
            s = s.ToLower();
            switch (s)
            {
                case "monday":
                    Console.WriteLine(1);
                    break;
                case "tuesday":
                    Console.WriteLine(2);
                    break;
                case "wednesday":
                    Console.WriteLine(3);
                    break;
                case "thursday":
                    Console.WriteLine(4);
                    break;
                case "friday":
                    Console.WriteLine(5);
                    break;
                case "saturday":
                    Console.WriteLine(6);
                    break;
                case "sunday":
                    Console.WriteLine(7);
                    break;
                default: Console.WriteLine("incorrect input");
                    break;
            }
            //Max distance in foot/meters is MAX
        }
    }
}
