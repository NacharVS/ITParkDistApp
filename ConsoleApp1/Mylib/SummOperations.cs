﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SummOperations
    {
        static void Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }
            Console.WriteLine(summ);
        }

        static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }

        static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
        static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
        static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }
    }
}
