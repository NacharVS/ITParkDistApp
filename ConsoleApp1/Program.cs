using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //1 задача:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Nubmer Max = " + a);
            else if (b > c)
                Console.WriteLine("Number Max = " + b);
            else
                Console.WriteLine("Number Max = " + c);
            //2 задача:
            Console.WriteLine("Insert in feets:");
            double feetDistance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); //0.305 meter
            Console.WriteLine("Insert in meters:");
            double meterDistance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double exchange = feetDistance * 0.305;
            if (exchange > meterDistance)
                Console.WriteLine("More is:" + feetDistance);
            else Console.WriteLine("More is:" + meterDistance);
            Console.ReadLine();*/
            //3 задача:
            Console.WriteLine("Insert in km/h:");
            double kmspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //0.305 meter
            Console.WriteLine("Insert in m/s:");
            double mspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double exchange = kmspeed * 0.277778;
            if (exchange > mspeed)
                Console.WriteLine("More is:" + kmspeed);
            else Console.WriteLine("More is:" + mspeed);
            Console.ReadLine();
        }
    }
}
