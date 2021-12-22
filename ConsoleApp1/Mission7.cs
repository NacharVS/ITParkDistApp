using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission7
    {
//7. Дана числовая последовательность от 1 до N.Найти такое число сумма цифр которого будет // наибольшей среди всей последовательности. Вывести само число и его сумму цифр // input 20 output 19 10 // input 44 output 39 12
        public static void Maxsum()
        {
            int number = int.Parse(Console.ReadLine());
            int max = 0;
            int MaxSumm = 0;

            for (int i = 1; i <= number; i++)
            {
                int a = i;
                int summ = 0;

                while (a > 0)
                {
                    summ += a % 10;
                    a = a / 10;
                }

                if (MaxSumm < summ)
                {
                    MaxSumm = summ;
                    max = i;
                }
            }
            Console.WriteLine($"number={max}  summ MAX={MaxSumm}");
        }
    }
}
