using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = i;
                while(a > 0)
                {
                    if(a % 10 == 7)
                    {
                        sum++;
                    }
                    a = a / 10;
                }
            }
            Console.WriteLine(sum);
            // input 20  output 2
            // input 100 output 20
        }
        //7 8 9 6
        //7897
        //7898
        //7899

    }
}
