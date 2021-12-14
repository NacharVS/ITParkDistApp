using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите три налуральных числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b & a > c)
                Console.WriteLine("среднее число:" +c);
            else
                if (b > a & b < c)
                Console.WriteLine("среднее число:" +b);
            else
                if (c > b & c < a)
                Console.WriteLine("среднее число:" +c);
            //


                





        }
    }
}