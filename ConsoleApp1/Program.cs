using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmh  = double.Parse(Console.ReadLine());
            double ms = double.Parse(Console.ReadLine());

            if (kmh * 0.28 > ms ) 
            {
                Console.WriteLine("max is: first speed (km)");
            }
            else
                Console.WriteLine("max is: second speed (ms)");
        }
    }
}
