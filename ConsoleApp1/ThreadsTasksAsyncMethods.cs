using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreadsTasksAsyncMethods
    {
        public static void SomeExpression1()
        {
            Console.WriteLine("Expressin one start");
            Thread.Sleep(3000);
            Console.WriteLine($"Expressinon 1 resuilt:{Math.Pow(2, 10)}");
            Console.WriteLine("Expressin one end");
        }
        public static void SomeExpression2(int n)
        {
            Console.WriteLine("Expressin two start");
            Thread.Sleep(4000);
            int res = 1;
            for (int i = 1 ; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Expressinon 2 resuilt:{res}");
            Console.WriteLine("Expressin two end");
        }

        public static async void ExpressionOneAsync()
        {
            await Task.Run(() => SomeExpression1());
        }


        public static async void ExpressionTwoAsync(int n)
        {
            Task task = new Task(() => SomeExpression2(n));
            task.Start();
            await task;
        }
    }
}
