using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson3Cycles
    {
        public static void CyclesPelmeni() //сколько пельменей можно слепить из указанного кол-ва теста и фарша
        {
            //1 pelmen = 2 testo+1 farsh
            int testo = int.Parse(Console.ReadLine());
            int farsh = int.Parse(Console.ReadLine());
            int pelmenCount = 0;
            //int pelmeneyNeeded = int.Parse(Console.ReadLine());
            for (int i = testo + farsh; i / 3 >= 1; i = i - 3)
            {
                if (testo >= 2 & farsh >= 1)
                {
                    pelmenCount++;
                    testo = testo - 2;
                    farsh = farsh - 1;
                }
                else break;
                Console.WriteLine($"Ptlmeney: {pelmenCount}, testo: {testo}, farsh: {farsh}");
            }
        }
        public static void ProductUpToEnteredNumber() //произведение чисел до введенного
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
        public static void DepositInteres() //нахождение процентов по вкладу
        {
            Console.Write("Введите сумму вклада: ");
            double depositSum = double.Parse(Console.ReadLine());
            Console.Write("Введите срок вклада в целых месяцах: ");
            int depositTerm = int.Parse(Console.ReadLine());
            double depositResult = 0;
            for (int i = 0; i <= depositTerm; i++)
            {
                depositResult = depositSum + (depositSum * 0.04);
            }
            Console.WriteLine($"Итоговая сумма к концу вклада: {depositResult}");
        }
        public static void DegreeOfNumber() //возведение введенного числа в указанную степень
        {
            Console.Write("Введите число, a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите степень, b: ");
            int b = int.Parse(Console.ReadLine());
            int r = 1;
            for (int i = 0; i < b; i++)
            {
                r = r * a;
            }
            Console.WriteLine($"A в степени B равно: {r}");
        }
        public static void SumDigitOfNumberInt() //сумма цифр в введенном числе (через for/Int).
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            //Console.WriteLine(c);
            for (int i = a; i > 0; i = i / 10)
            {
                sum += a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
        public static void SumDigitOfNumberChar() //сумма цифр в введенном числе (через for/Char).
        {
            Console.WriteLine("Введите число, а мы найдем сумму его цифр: ");
            string a = Console.ReadLine();
            int b = a.Length;
            double sum = 0;
            for (int i = 0; i < b; i++)
            {
                Char.GetNumericValue(a[i]);
                sum +=(a[i]-'0');
            }
            Console.WriteLine(sum);
        }
        public static void SumDigitOfNumberWhile() //сумма цифр в введенном числе (через While).
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
        public static void NumberReverse() //Переворот числа
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum = sum * 10 + a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
        public static void DevideByZeroBreak() //делим числа последовательности 2-10 (шаг 2) на диапазон -3:3. Выходим при делении на ноль.
        {
            for (int i = 2; i < 10; i = i + 2)
            {
                for (int j = -3; j < 3; j++)
                {
                    if (j == 0) break;
                    else
                        Console.WriteLine((double)i / j);
                }
                Console.WriteLine();
            }
        }
        public static void CombinationLockNoCheck()//нахождение комбинаций 3х значного кодового замка без проверок на дубли
        {
            int summ = int.Parse(Console.ReadLine());
            for (int i = 1; i < 999; i++)
            {
                if (summ == i % 10 + i / 100 + i / 10 % 10)
                {
                    Console.WriteLine($"{i / 100}{i / 10 % 10}{i % 10}");
                }
            }
        }
        public static void Find7InEnteredNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = i;
                while (a > 0)
                {
                    if (a % 10 == 7) count++;
                    a = a / 10;
                }
            }
            Console.WriteLine($"Count: {count}");
        }
    }
}
