using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods
    {
        public static int Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (int item in numbers)
            {
                summ += item;
                Console.WriteLine(summ);
            }
            return summ;

        }

        public static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }

        public static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
        public static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
        public static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }

        public static int Summ1(int a, int b)
        {
            return a + b;

        }
    }
}
