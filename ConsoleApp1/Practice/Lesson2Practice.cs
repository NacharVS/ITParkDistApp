using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson2Practice
    {
        public static void MeanOfNumber() //Практика 1: Вводиться 3 натуральных числа. Найти среднее из них.
        //(Пример ввода/вывода: 7 66 5/Результат 7; Пример ввода/вывода: 2 4 8/Результат 4)
        {
            Console.Write("Введите три натуральных числа через пробел: ");
            string inputNumber = Console.ReadLine();
            string[] tokens = inputNumber.Split(' ');
            int firstDigit = int.Parse(tokens[0]);
            int secondDigit = int.Parse(tokens[1]);
            int thirdDigit = int.Parse(tokens[2]);
            if ((firstDigit > secondDigit & firstDigit <= thirdDigit) || (firstDigit > thirdDigit & firstDigit <= secondDigit))
                Console.WriteLine($"Среднее число: {firstDigit}");
            else
                if ((secondDigit >= firstDigit & secondDigit <= thirdDigit) || (secondDigit >= thirdDigit & secondDigit <= firstDigit))
                Console.WriteLine($"Среднее число: {secondDigit}");
            else Console.WriteLine($"Среднее число: {thirdDigit}");
        }
        public static void SumOrProductofNumber()//Практика 2: Дано трехзначное число. Если оно четное, то найти сумму цифр
        //если оно нечетное, найти произведение.
        //(Пример ввода/вывода: 123/Результат 6; Пример ввода/вывода: 666 /Результат 18)
        {
            Console.Write("Введите трехзначное число: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int firstDigit = inputNumber / 100;
            int secondDigit = (inputNumber % 100) / 10;
            int thirdDigit = inputNumber % 10;
            if (inputNumber % 2 <= 0)
                Console.WriteLine($"Четное. Сумма цифр: {firstDigit + secondDigit + thirdDigit}");
            else Console.WriteLine($"Нечетное. Произведение цифр: {firstDigit * secondDigit * thirdDigit}");
        }
        public static void FigureArea()//Практика 3: Написать программу, которая, в зависимости от выбора пользователя, предложит найти площадь геометрической фигуры. 
        //(Пример работы программы: Выберите фигуру: square, введите длину одной стороны квадрата: 4, Площадь квадрата: 16)
        {
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1.квадрат");
            Console.WriteLine("2.прямоугольник");
            Console.WriteLine("3.параллелограмм");
            Console.WriteLine("4.круг");
            Console.WriteLine("5.треугольник");
            var geometricFigure = Console.ReadLine();
            switch (geometricFigure)
            {
                case "1":
                    {
                        Console.Write("Введите длину стороны квадрата: ");
                        double side = double.Parse(Console.ReadLine());
                        double area = Math.Pow(side, 2);
                        Console.WriteLine($"Площадь квадрата: {area}");
                    }
                    break;
                case "2":
                    {
                        Console.Write("Введите длину одной стороны прямоугольника: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину другой стороны прямоугольника: ");
                        double side2 = double.Parse(Console.ReadLine());
                        double area = side1 * side2;
                        Console.WriteLine($"Площадь прямоугольника: {area}");
                    }
                    break;
                case "3":
                    {
                        Console.Write("Введите длину одной стороны параллелограмма: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину высоты, опущенной на указанную сторону: ");
                        double high = double.Parse(Console.ReadLine());
                        double area = side * high;
                        Console.WriteLine($"Площадь параллелограмма: {area}");
                    }
                    break;
                case "4":
                    {
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI * Math.Pow(radius, 2);
                        Console.WriteLine($"Площадь круга: {area}");
                    }
                    break;
                case "5":
                    {
                        Console.Write("Введите длину одной стороны треугольника:");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину высоты, опущенной на указанную сторону:");
                        double high = double.Parse(Console.ReadLine());
                        double area = (side * high) / 2;
                        Console.WriteLine($"Площадь треугольника: {area}");
                    }
                    break;
            }
        }
        public static void DepositInteres()//4. Написать программу для вычисления процентов по вкладу (ставка составляет 4% в месяц).
        //Пользователь вводит сумму вклада и количество месяцев. Проценты начисляются каждый месяц.
        //(Пример ввода / вывода: 4000 4 Результат: 4679,43424)
        {
            Console.Write("Введите сумму вклада: ");
            double depositSum = double.Parse(Console.ReadLine());
            Console.Write("Введите срок вклада в целых месяцах: ");
            int depositTerm = int.Parse(Console.ReadLine());
            double depositResult = depositSum * (Math.Pow(1.04, depositTerm));
            Console.WriteLine($"Итоговая сумма к концу вклада: {depositResult}");
        }
    }
}
