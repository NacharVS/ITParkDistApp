using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission5
    {
        //5. Сократить количество комбинаций, хотя бы в 2 раза.См.коммит "combinations" от 9.12.2021 21:01
        public static void Combination()
        {
            int summ = int.Parse(Console.ReadLine());
            int combinations = 0;// 1 < summ < 27
            for (int i = 0; i <= 7; i++)
            {
                for (int j = i + 1; j <= 8; j++)
                {

                    for (int k = j + 1; k <= 9; k++)
                    {
                        if (i + j + k == summ && i != j && j != k && i != k)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                            break;
                        }
                    }

                }

            }
            Console.WriteLine($" count {combinations}");
        }
    }
}
