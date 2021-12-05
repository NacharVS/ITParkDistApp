using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first speed (km/h) : ");
            double kmh  = double.Parse(Console.ReadLine());

            Console.WriteLine("first speed (m/s) : ");
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
