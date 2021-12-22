using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission1
    {
//       1. Вводиться 3 натуральных числа.Найти среднее из них.
//(Пример ввода/вывода: 7 66 5/Результат 7; Пример ввода/вывода: 2 4 8/Результат 4)

        public static void Averagenumber()
        {
            Console.WriteLine("Please enter three numbers ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 < number3)
            {
                Console.WriteLine(number1);
            }
            else if (number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 < number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }
            Console.ReadKey();
        }
    }
}
