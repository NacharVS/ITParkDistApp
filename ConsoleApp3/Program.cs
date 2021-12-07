using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Площадь произвольной фигуры.");

            double Edge, Heigh;
            string Shape;

            Console.Write("Введите название фигуры (треугольник, круг или квадрат): ");
            Shape = Console.ReadLine();
            Shape.ToLower();

            switch (Shape)
            {
                case "квадрат":
                    {
                        Console.Write("Введите длину стороны: ");
                        Edge = double.Parse(Console.ReadLine());

                        Console.WriteLine("Площадь поверхности квадрата со стороной {0} равна {1}.", Edge, Math.Pow(Edge, 2));
                    }
                    break;
                case "треугольник":
                    {
                        Console.Write("Введите длину основания: ");
                        Edge = double.Parse(Console.ReadLine());
                        Console.Write("Введите высоту: ");
                        Heigh = double.Parse(Console.ReadLine());

                        Console.WriteLine("Площадь поверхности треугольника с длиной основания {0} и высотой {1} равна {2}.", Edge, Heigh, Edge*Heigh/2);
                    }
                    break;
                case "круг":
                    {
                        Console.Write("Введите длину радиуса: ");
                        Edge = double.Parse(Console.ReadLine());

                        Console.WriteLine("Площадь поверхности круга с радиусом {0} равна {1}", Edge, Math.PI * Math.Pow(Edge, 2));
                    }
                    break;
                default:
                    Console.WriteLine("Фигура не обнаружена!");
                    break;
            }
                
        }
    }
}
