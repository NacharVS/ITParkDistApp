using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int ed = number % 10;
            int des = number / 10 % 10;
            int hun = number / 100;
                if (ed == 0)
                Console.WriteLine(ed * des * hun);
            else
                if (ed==2)
                Console.WriteLine(ed * des * hun);
            else
                if (ed == 4)
                Console.WriteLine(ed * des * hun);
            else
                if (ed == 6)
                Console.WriteLine(ed * des * hun);
            else
                if (ed == 8)
                Console.WriteLine(ed * des * hun);
            else
                if (ed == 1)
                Console.WriteLine(ed + des + hun);
            else
                if (ed == 3)
                Console.WriteLine(ed + des + hun);
            else
                if (ed == 5)
                Console.WriteLine(ed + des + hun);
            else
                if (ed == 7)
                Console.WriteLine(ed + des + hun);
            else
                if (ed == 9)
                Console.WriteLine(ed + des + hun);

        }
    }
}
