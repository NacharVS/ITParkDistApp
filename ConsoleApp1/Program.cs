using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Прямоугольник");
            Console.WriteLine("3. Круг");
            Console.WriteLine("4. Треугольник");
            Console.WriteLine("5. Ромб");
            int figure = int.Parse(Console.ReadLine());
            switch (figure)
            { 
                case 1:
                    {
                        Console.WriteLine("Введите значение стороны:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь квадрата равна: {a * a}");
                    }
                    break;
                    case 2:
                    {
                        Console.WriteLine("Введите значение длины:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение ширины:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь прямоугольника равна: {a * b}");
                    }
                    break;
                    case 3:
                    {
                        Console.WriteLine("Введите значение радиуса:");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь круга равна: {Math.PI * Math.Pow(r,2)}");
                    }
                    break;
                    case 4:
                    {
                        Console.WriteLine("Введите значение основания:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение высоты:");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь треугольника равна: {0.5 * a*h}");
                    }
                    break;
                    case 5:
                    {
                        Console.WriteLine("Введите значение стороны:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение высоты:");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь ромба равна: {a * h}");
                    }
                    break;
            }
                


        }
    }
}
