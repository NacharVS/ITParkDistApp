using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission6
    {
        //6. Ввывести представление числа N в виде простых множителей. // input 6 output 2 3 // intput 30 output 2 3 5 // input 16 output 2 2 2 2
        public static void Simplemultiplier()
        {
            int number = int.Parse(Console.ReadLine());
            while (number > 1 && number % 2 == 0)
            {
                Console.WriteLine(2);
                number = number / 2;
            }

            int i = 3;
            while (number > 1)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
                i = i + 2;
            }
        }
    }
}
