using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreadsTasksAsyncMethods
    {
        public static void SomeExpression1()
        {
            Console.WriteLine($"Expressinon 1 resuilt:{Math.Pow(2, 10)}");
        }
        public static void SomeExpression2(int n)
        {            
            int res = 1;
            for (int i = 1 ; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Expressinon 2 resuilt:{res}");
        }
    }
}
