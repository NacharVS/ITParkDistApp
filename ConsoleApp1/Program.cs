using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Среднее число
            /*
            Console.WriteLine("введите три налуральных числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b & a > c)
                Console.WriteLine("среднее число:" + c);
            else
                if (b > a & b < c)
                Console.WriteLine("среднее число:" + b);
            else
                if (c > b & c < a)
                Console.WriteLine("среднее число:" + c);*/

            // Сумма/Произведение

            /* Console.WriteLine("Ведите трехзначное число:");
             int number = int.Parse(Console.ReadLine());
             int ed = number % 10;
             int des = number / 10 % 10;
             int hun = number / 100;
             if (number % 2 <= 0)
                 Console.WriteLine($"четное. Сумма цифр:{ed + des + hun}");
             else
                 Console.WriteLine($"нечетное. Произведение цифр:{ed * des * hun}");*/
            // Площадь фигур
            /*
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1.Квадрат:");
            Console.WriteLine("2.Треугольник:");
            Console.WriteLine("3.Прямоугольник:");
            Console.WriteLine("4.Круг:");
            var geometricFigure = Console.ReadLine();
            switch (geometricFigure)
            {
                case "1":
                    {
                        Console.Write("Введите длину стороны квадрата:");
                        double side = double.Parse(Console.ReadLine());
                        double area = Math.Pow(side, 2);
                        Console.WriteLine($"Площадь квадрата: {area}");
                    }
                    break;
                case "2":
                    {
                        Console.Write("Введите длину одной стороны треугольника:");
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длину высоты:");
                        double high = double.Parse(Console.ReadLine());
                        double area = (side * high) / 2;
                        Console.WriteLine($"Площадь треугольнока: {area}");
                    }
                    break;
                case "3":
                    {
                        Console.Write("Ведите длину одной стороны прямоугольника:");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину другой стороны прямоугольника:");
                        double side2 = double.Parse(Console.ReadLine());
                        double area = side1 * side2;
                        Console.WriteLine($"Площадь прямиугольника: {area}");

                    }
                    break;
                case "4":
                    {
                        Console.Write("Введите радиус круга:");
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI* Math.Pow(radius, 2);
                        Console.WriteLine($"Площадь круга: {area}");
                    }
                    break;*/
           





        }














    }
    }
