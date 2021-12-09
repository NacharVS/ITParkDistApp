using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            double resalt = 1;

            for (int i = 1; i <= b; i++)
            {
                resalt = resalt * a;
            }

            Console.WriteLine(resalt);



        }


    }
}
