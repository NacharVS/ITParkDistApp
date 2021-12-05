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
            /*Console.WriteLine("Insert in km/h:");
            double kmspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //0.305 meter
            Console.WriteLine("Insert in m/s:");
            double mspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double exchange = kmspeed * 0.277778;
            if (exchange > mspeed)
                Console.WriteLine("More is:" + kmspeed);
            else Console.WriteLine("More is:" + mspeed);
            Console.ReadLine();*/
            //4 задача
            /*Console.WriteLine("Input the season:");
            string s = Console.ReadLine();
            s=s.ToLower();
            switch(s)
            {
                case "winter":Console.WriteLine("December,January,February");
                    break;
                case "summer":
                    Console.WriteLine("June,July,August");
                    break;
                case "spring":
                    Console.WriteLine("March,May,April");
                    break;
                case "autumn":
                    Console.WriteLine("September,October,November");
                    break;
                /*case "friday":
                    Console.WriteLine(5);
                    break;
                case "saturday":
                    Console.WriteLine(6);
                    break;
                case "sunday":
                    Console.WriteLine(7);
                    break;
                default:Console.WriteLine("Incorrect season! Try again...");
                    break;*/
            //goto "winter";*/
            //5 задача
            int bread = 10;
            int sugar = 20;
            int milk = 30;
            Console.WriteLine("How money do you have?");
            int deneg=int.Parse(Console.ReadLine());
            Console.WriteLine("Choose product: bred(10ue)/sugar(20ue)/milk(30ue)");
            string product = Console.ReadLine();
            Console.WriteLine("How mach " + product + " do you need?");
            int amountProduct=int.Parse(Console.ReadLine());
            switch (product)
            {
                case "bred":
                    int b = amountProduct * bread;
                    if (b<=deneg)
                    Console.WriteLine("Summa:"+b+" :  You money is enough for "+amountProduct+" "+product);
                    else Console.WriteLine("Summa:" + b + " :  You money is NOT enough for " + amountProduct + " " + product+ " !");
                    break;
                case "sugar":
                    int s = amountProduct * bread;
                    if (s <= deneg)
                        Console.WriteLine("Summa:" + s + " :  You money is enough for " + amountProduct + " " + product);
                    else Console.WriteLine("Summa:" + s + " :  You money is NOT enough for " + amountProduct + " " + product+" !");
                    break;
                case "milk":
                    int m = amountProduct * bread;
                    if (m <= deneg)
                        Console.WriteLine("Summa:" + m + " :  You money is enough for " + amountProduct + " " + product);
                    else Console.WriteLine("Summa:" + m + " :  You money is NOT enough for " + amountProduct + " " + product+" !");
                    break;
                
            }

        }
    }
}
