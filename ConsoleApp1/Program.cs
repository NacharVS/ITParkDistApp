using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double footDistance = double.Parse(Console.ReadLine()); //0.305 metr
            double metrDistance = double.Parse(Console.ReadLine());


            if (footDistance * 0.305 > metrDistance)
            {
                Console.WriteLine ("max is:");
                Console.WriteLine (footDistance * 0.305);
            }
            else
            { 
                Console.Write ("max is: ");
                Console.Write (metrDistance);
            }
            
        }
    }
}
