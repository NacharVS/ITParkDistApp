using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cash, CashOutput;
            byte Perscent, Mounths;
            string Format;

            Console.Write("Здравствуйте! Вас приветствует онлайн-калькулятор счёта по % от вклада.\nВведите сумму, которую Вы хотите рассчитать: ");
            Cash = Math.Abs(float.Parse(Console.ReadLine()));
            Console.Write("Введите % интересующего Вас счёта: ");
            Perscent = byte.Parse(Console.ReadLine());
            Console.Write("Введите количество месяцев, чтобы рассчитать сумму за период: ");
            Mounths = byte.Parse(Console.ReadLine());

            CashOutput = Cash + Cash*Perscent/100 * Mounths;
            Format = String.Format("{0:.00}", CashOutput);
            Console.WriteLine("Сумма Вашего счёта с вкладом {0} под {1}% через {2} мес. будет составлять: {3}", Cash, Perscent, Mounths, Format);
        }
    }
}
