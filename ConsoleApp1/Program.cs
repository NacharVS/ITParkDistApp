using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.WriteLine(a);
            else
               if ((a > c) && (b > a))
                Console.WriteLine(a);
            else
               if ((b > a) && (c > b)) 
                Console.WriteLine(b);
            else
                if ((b > c) && (a > b)) 
                Console.WriteLine(b);
            else
                if ((c > b) && (a > c)) 
                Console.WriteLine(c);
            else
                if ((c > a) && (b > c))
                Console.WriteLine(c);
        }
    }
}
