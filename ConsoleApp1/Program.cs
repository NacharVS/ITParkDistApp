using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //среднее значение

            Console.WriteLine("Еnter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Еnter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Еnter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int mean = (number1 + number2 + number3) / 3;

            Console.WriteLine($"Mean: { mean }");
           

            //трехзначное число. четное, то найти сумму цифр, если оно нечетное, найти произведение.

            Console.WriteLine("Enter a three-digit number: ");

            int number = int.Parse(Console.ReadLine());
            int a = number % 10;
            int b = number / 10 % 10;
            int c = number / 100;
            int d = a + b + c;
            int e = a * b * c;

            if (number % 2 == 0)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }

            

            //Написать программу, которая, в зависимости от выбора пользователя, предложит найти площадь геометрической фигуры. 
            Console.WriteLine("Choose a figure");
            Console.WriteLine("1. square ");
            Console.WriteLine("2. rectangle");
            int figure = int.Parse(Console.ReadLine());


            if (figure == 1)
            {
                Console.Write("enter side length: ");
                int lenght = int.Parse(Console.ReadLine());
                double Ssquare = Math.Pow(lenght, 2); 
                Console.WriteLine($"Square area = {Ssquare}");
            }
            else
            {
                Console.Write("enter side length rectangle: ");
                int lenghtRes = int.Parse(Console.ReadLine());
                Console.Write("enter side width rectangle: ");
                int widthRes = int.Parse(Console.ReadLine());
                int Srectangle = lenghtRes * widthRes;
                Console.WriteLine($"Restangle area = {Srectangle}");
            }
            

            

            //Написать программу для вычисления процентов по вкладу (ставка составляет 4% в месяц). 

            Console.Write("Calculation of interest on a deposit. With a rate of 4% per month.");
            Console.WriteLine();
            Console.Write("Enter the initial deposit: ");
            double deposit = int.Parse(Console.ReadLine());
            Console.Write("Term of the contract in months:  ");
            int numberMonths = int.Parse(Console.ReadLine());
            double bid = 1 + 0.04;
            double initialDeposit = deposit * Math.Pow(bid, numberMonths);
            Console.Write($"Total income:  {initialDeposit}"); 
            

    

        }
    }
}
