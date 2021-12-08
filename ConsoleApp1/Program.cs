using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {    //Задание № 1.
            //int a, b, c;
            
            //Console.WriteLine("Введите число 1");
            //a = int.Parse(Console.ReadLine());


            //Console.WriteLine("Введите число 2");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите  число 3");
            //c = int.Parse(Console.ReadLine());

            //int result = a;

            //if ((a < b && b < c) || (a > b && b > c))
            //{
            //    result = b;
            //}
            //else if ((b < c && c < a) || (b > c && c > a))
            //{
            //    result = c;
            //}
            //Console.WriteLine($"Среднее число   {result}");

            //----------------------------------------------------------------------

            //Задание № 2.

            //int summa;
            //int a;
            //int b;
            //int c;
            //int result;
            //int result2;
            //Console.WriteLine("Введите трехзначное число");
            //summa = int.Parse(Console.ReadLine());


            //a = summa / 100;
            //b = (summa % 100) / 10;
            //c = summa % 10;
            //if (summa % 2 == 0)
            //{
            //    Console.WriteLine("Вы ввели четное число");
            //    result = a + b + c;

            //    Console.WriteLine("Cумма трех чисел = " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Число не четное");
            //    result2 = a * b * c;
            //    Console.WriteLine("Произведение = "+result2);
            //}

            //----------------------------------------------------------------------

            //Задание № 3.
            //int Radius;
            //int side;
            //double footing;
            //double height;

            //double S;


            //Console.WriteLine("Выбирите геометрическую фигуру:круг,квадрат,треугольник");
            //string figure = Console.ReadLine();
            //switch (figure)
            //{
            //    case "круг":
            //        Console.WriteLine("Выбирите радиус круга в см.");
            //        Radius = int.Parse(Console.ReadLine());
            //        S = Radius * 2;
            //        Console.WriteLine("Площадь круга = " + S);
            //        break;

            //    case "квадрат":
            //        Console.WriteLine("Выбирите одну сторону квадрата в см.");
            //        side = int.Parse(Console.ReadLine());
            //        S = side * side;
            //        Console.WriteLine("Площадь квадрата= " + S);
            //        break;

            //    case "треугольник":
            //        Console.WriteLine("введите основание треугольника в см.");
            //        footing = double.Parse(Console.ReadLine());


            //        Console.WriteLine("Введите высоту треугольника в см.");
            //        height = double.Parse(Console.ReadLine());

            //        S = footing * height/2;



            //        Console.WriteLine("Площадь треугольника= " + S);
            //        break;
            //}

            //----------------------------------------------------------------------

            //Задание № 4.
            double Summa;
            int day;
            Console.WriteLine("Введите сумму вклада");
            Summa = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество дней");
            day = int.Parse(Console.ReadLine());







        }
    }
}
