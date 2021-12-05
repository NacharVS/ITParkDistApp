using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double footDistance = double.Parse(Console.ReadLine()); //0.305 meter
            double meterDistance = double.Parse(Console.ReadLine());
            
            if (footDistance * 0.305 > meterDistance)
            {
                Console.WriteLine($"Max distance in foots {footDistance}");
            }
            else
            {
                Console.WriteLine($"Max distance in meters {meterDistance}");
            }

            //Max distance in foot/meters is MAX
        }
    }
}
