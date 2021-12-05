using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double footDistance  = double.Parse(Console.ReadLine());
            double MeterDistance = double.Parse(Console.ReadLine());
            double footDistance_to_Metr = footDistance * 0.3040;

            if (MeterDistance > footDistance_to_Metr) 
            {
                Console.WriteLine("max is: Seconde distance (MeterDistance)");
            }
            else
                Console.WriteLine("max is: First distance (footDistance)");
        }
    }
}
