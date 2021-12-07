using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a figure"); //выберите фигуру
            Console.WriteLine("1 Triangle"); //треугольник
            Console.WriteLine("2 Square"); //квадрат
            Console.WriteLine("3 Rectangle"); //прямоугольник
            Console.WriteLine("4 Cicrle"); // круг
            Console.WriteLine("5 Сylinder"); //цилиндр
            
            int figure = Convert.ToInt32(Console.ReadLine());
            switch (figure)
            {
                    case 1:
                    Console.WriteLine("enter the height"); //введите высоту
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter the base"); //введите основание
                    double a = double.Parse(Console.ReadLine());
                    if (h>0 && a>0)
                    {
                        double s = a * h / 2;
                        Console.WriteLine($"The area of the triangle is equal to S={s}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("incorrect data");
                        Console.ReadKey();
                    }
                    break;
                    case 2:
                    Console.WriteLine("enter a value"); //введите значение
                    double b = double.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        double s = b*b;
                        Console.WriteLine($"The area of the square is equal to S={s}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("incorrect data");
                        Console.ReadKey();
                    }
                    break;
                    case 3:
                    Console.WriteLine("enter the length"); //введите длину
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter the width"); //введите ширину
                    double w = double.Parse(Console.ReadLine());
                    if (l > 0 && w > 0)
                    {
                        double s = l * w;
                        Console.WriteLine($"The area of the rectangle is equal to S={s}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("incorrect data");
                        Console.ReadKey();
                    }
                    break;
                    case 4:
                    Console.WriteLine("enter a value"); //введите значение
                    double R = double.Parse(Console.ReadLine());
                    if (R > 0)
                    {
                        double s = 3.14*R*R;
                        Console.WriteLine($"The area of the сicrle is equal to S={s}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("incorrect data");
                        Console.ReadKey();
                    }
                    break;
                    case 5:
                    Console.WriteLine("enter the height "); //введите высоту
                    double H = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter the radius "); //введите радиус
                    double G = double.Parse(Console.ReadLine());
                    if (H > 0 && G > 0)
                    {
                        double s =  2*3.14*G*H+2*3.14*G*G;
                        Console.WriteLine($"The area of the cylinder is equal to S={s}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("incorrect data");
                        Console.ReadKey();
                    }
                    break;
                    default:
                    Console.WriteLine("incorrect data");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
