using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            int max = 0;
            int min = 0;

            bool isCorrect = true;

            Console.WriteLine("First number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Third number:");
            int c = int.Parse(Console.ReadLine());

            //Проверка на равные числа
            if (a == b)
                isCorrect = false;

            if (a == c)
                isCorrect = false;

            if (b == c)
                isCorrect = false;

            if (isCorrect == true)
            {
                if (a > b && a > c)
                {
                    max = a;

                    if (b > c)
                        min = c;
                    else
                        min = b;
                }


                if (a > b && a < c)
                {
                    max = c;
                    min = b;
                }

                if (a < b && b > c)
                {
                    max = b;

                    if (a > c)
                        min = c;
                    else
                        min = a;
                }

                if (a < b && b < c)
                {
                    max = c;
                    min = a;
                }

                if (a < max && a > min)
                    Console.WriteLine("Number in the middle - " + a);

                if (b < max && b > min)
                    Console.WriteLine("Number in the middle - " + b);

                if (c < max && c > min)
                    Console.WriteLine("Number in the middle - " + c);
            }
            else
                Console.WriteLine("Re-enter numbers - enter different numbers");

            Console.ReadKey();

            // Задание 2 

            //int number;
            //Console.WriteLine("введите число: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //int a = 0;
            //int b = 0;
            //int c = 0;

            //a = number / 100;
            //b = (number % 100) / 10;
            //c = (number % 100) % 10;

            //int result = 0;

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("четное число");
            //    result = a + b + c;
            //    Console.WriteLine("result - " + result);
            //}
            //else
            //{
            //    Console.WriteLine("нечетное");
            //    result = a * b * c;
            //    Console.WriteLine("result - " + result);
            //}

            //Console.ReadKey();

            //Задание 3         

            //Console.WriteLine("Сhoose a geometric shape");

            //Console.WriteLine("1-square");

            //Console.WriteLine("2-rectangle");

            //Console.WriteLine("3-circle");



            //int number = int.Parse(Console.ReadLine());

            //double S = 0;
            //switch(number)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Is selected - square. Enter the size of the side ");
            //            int side = int.Parse(Console.ReadLine());
            //            S = side * side;
            //            Console.WriteLine($"Square area: {S}");

            //        }
            //        break;
            //    case 2:
            //        {
            //            Console.WriteLine("Is selected - rectangle. Enter the size of the side1");
            //            int side1 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Enter the size of the side2");
            //            int side2 = int.Parse(Console.ReadLine());

            //            S = side1 * side2;
            //            Console.WriteLine($"Rectangle area: {S}");
            //        }
            //        break;
            //    case 3:
            //        {

            //            Console.WriteLine("Is selected - Circle. enter radius");
            //            int side = int.Parse(Console.ReadLine());

            //            S = 3.14 * side * side;

            //            Console.WriteLine($"Circle area: {S}");
            //        }
            //        break;
            //}

            //Console.ReadKey();


            //Задание 4

            //Console.WriteLine("Enter the amount of the deposit");
            //double deposit = int.Parse(Console.ReadLine());

            //Console.WriteLine("Number of months");
            //int months = int.Parse(Console.ReadLine());

            //double result = 0;

            //result = months * (deposit * 4) / 100 + deposit;

            //Console.WriteLine($"Result: {result}");

            //Console.ReadKey();
        }
    }
}
