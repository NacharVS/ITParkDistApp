using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission2
    {
//        2. Дано трехзначное число.Если оно четное, то найти сумму цифр, если оно нечетное, найти произведение.
//(Пример ввода/вывода: 123/Результат 6; Пример ввода/вывода: 666 /Результат 18)

        public static void Evenodd()
        {

            Console.WriteLine("please enter a three digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 99 && number < 1000)
            {
                double number1 = number / 2 % 1;
                if (number1 == 0)
                {
                    int one = number % 10;
                    int two = number / 10 % 10;
                    int three = number / 100;
                    Console.WriteLine(one + two + three);
                }
                else
                {
                    int one = number % 10;
                    int two = number / 10 % 10;
                    int three = number / 100;
                    Console.WriteLine(one * two * three);
                }
            }
            else
            {
                Console.WriteLine("incorrect data");
            }
        }
    }
}
