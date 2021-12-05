using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double footDistance = int.Parse(Console.ReadLine()); //0.305 meter
            double meterDistence = int.Parse(Console.ReadLine());
            doble footsTometers = footDistance * 0.305

            if (footsTometers > meterDistence)
            {
                Console.WriteLine($"Max distance in meters is { footsTometers}");
            }
            else
                Console.WriteLine($"Max distance in meters is { meterDistence}");
        }
    }
}
