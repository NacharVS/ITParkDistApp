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
            if (a > b) // < > == <= >=  
            {
                Console.WriteLine("max is:");
                Console.WriteLine(a);
            }            
            else
                Console.WriteLine(b);
        }
    }
}
