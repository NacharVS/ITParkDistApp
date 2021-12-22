using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission4
    {
//        4. Написать программу для вычисления процентов по вкладу(ставка составляет 4% в месяц). Пользователь вводит сумму вклада и количество месяцев.Проценты начисляются каждый месяц.
//(Пример ввода/вывода: 4000 4 Результат: 4679,43424)

        public static void Percent()
        {
            Console.WriteLine("Please enter the amount"); //Пожалуйста, введите сумму
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of months"); //Пожалуйста, введите количество месяцев
            int months = Convert.ToInt32(Console.ReadLine());
            if (money > 0 && months > 0)
            {
                double accumulation = money * Math.Pow(1.04, months);
                Console.WriteLine($"Amount of savings={accumulation}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect data");
                Console.ReadKey();
            }
        }
    }
}
