using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //������� �����
            /*
            Console.WriteLine("������� ��� ����������� �����:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b & a > c)
                Console.WriteLine("������� �����:" + c);
            else
                if (b > a & b < c)
                Console.WriteLine("������� �����:" + b);
            else
                if (c > b & c < a)
                Console.WriteLine("������� �����:" + c);*/

            // �����/������������

            /* Console.WriteLine("������ ����������� �����:");
             int number = int.Parse(Console.ReadLine());
             int ed = number % 10;
             int des = number / 10 % 10;
             int hun = number / 100;
             if (number % 2 <= 0)
                 Console.WriteLine($"������. ����� ����:{ed + des + hun}");
             else
                 Console.WriteLine($"��������. ������������ ����:{ed * des * hun}");*/
            // ������� �����
            /*
            Console.WriteLine("�������� ������:");
            Console.WriteLine("1.�������:");
            Console.WriteLine("2.�����������:");
            Console.WriteLine("3.�������������:");
            Console.WriteLine("4.����:");
            var geometricFigure = Console.ReadLine();
            switch (geometricFigure)
            {
                case "1":
                    {
                        Console.Write("������� ����� ������� ��������:");
                        double side = double.Parse(Console.ReadLine());
                        double area = Math.Pow(side, 2);
                        Console.WriteLine($"������� ��������: {area}");
                    }
                    break;
                case "2":
                    {
                        Console.Write("������� ����� ����� ������� ������������:");
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine("������� ����� ������:");
                        double high = double.Parse(Console.ReadLine());
                        double area = (side * high) / 2;
                        Console.WriteLine($"������� ������������: {area}");
                    }
                    break;
                case "3":
                    {
                        Console.Write("������ ����� ����� ������� ��������������:");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("������� ����� ������ ������� ��������������:");
                        double side2 = double.Parse(Console.ReadLine());
                        double area = side1 * side2;
                        Console.WriteLine($"������� ��������������: {area}");

                    }
                    break;
                case "4":
                    {
                        Console.Write("������� ������ �����:");
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI* Math.Pow(radius, 2);
                        Console.WriteLine($"������� �����: {area}");
                    }
                    break;*/
           





        }














    }
    }
