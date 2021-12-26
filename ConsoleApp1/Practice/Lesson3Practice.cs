using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HOMEWORK
//(V)1.Сократить кол-во комбинаций.
//(V)2.Вывести представление числа N в виде простых множетелей.
//      input 6 output 2 3
//      input 30 output 2 3 5
//      input 16 output 2 2 2 2
//(V)3.Дана числовая последовательность от 1 до N;
//      Найти такое число сумма цифр которого будет наибольшей среди всей последовательности;
//      Вывести само число и его сумму цифр.
//      input (1 до n) 20 output 19 10
//      input 44 output 39 12
namespace ConsoleApp1
{
    internal class Lesson3Practice
    {
        public static void CombinationLock()//Практика 1: нахождение комбинаций 3х значного кодового замка по его сумме c проверками на дубли
        {
            Console.Write("Введите сумму цифр кодовой комбинации замка: ");
            int combinations = 0;
            int summ = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i + j + k == summ && i < j && j < k)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine($"Всего комбинаций: {combinations}");
        }
        public static void SimpleFactors() //Практика 2: Простые множители.
        {
            Console.Write("Введите число для поиска его простых множителей: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"{number} = 1");
            for (int i = 0; number % 2 == 0; number /= 2)
            {
                Console.Write(" * 2");
            }
            for (int i = 3; i <= number;)
            {
                if (number % i == 0)
                {
                    Console.Write($" * {i}");
                    number /= i;
                }
                else
                {
                    i += 2;
                }
            }
        }
        public static void SimpleFactors2() //второй вариант нахождения простых множителей (разбор с Вадимом)
        {
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            while (number > 1)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (number % divider == 0)
                    {
                        number = number / divider;
                        Console.WriteLine(divider);
                    }
                    else divider++;
                }
            }
        }
        public static void MaxSumNumber() //Практика 3: Нахождение максимальной суммы цифр в числовом ряде
        {
            Console.Write("Введите конечное число N ряда 1...N: ");
            int sequence = int.Parse(Console.ReadLine());
            int numberOfMaxSum = 0;
            int maximumSum = 0;
            for (int i = 1; i <= sequence; i++)
            {
                int numberOfSequence = i;
                int sumOfNumber = 0;
                for (int j = numberOfSequence; j > 0; j = j / 10)
                {
                    sumOfNumber += numberOfSequence % 10;
                    numberOfSequence = numberOfSequence / 10;
                }
                //Console.WriteLine($"Число ряда: {i} имеет сумму цифр: {sumOfNumber}");
                if (sumOfNumber > maximumSum)
                {
                    maximumSum = sumOfNumber;
                    numberOfMaxSum = i;
                }
            }
            Console.WriteLine($"В заданном ряде (1-{sequence}) число {numberOfMaxSum} имеет максимальную сумму цифр: {maximumSum}");
        }
    }
}
