using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverse of digit
            Console.WriteLine("enter number ");
            int number1 = int.Parse(Console.ReadLine());
            double reverseDigit = 0;
            int n = number1;
            int n1 = 0;
            while (n > 0)
            {
                n1 = n1 + 1;
                n = n / 10;
            }
            while (number1 > 0)
            {
                reverseDigit = reverseDigit + number1 % 10 * Math.Pow(10, n1 - 1);
                n1 = n1 - 1; 
                number1 = number1 / 10;
                
            }
            Console.WriteLine($"The reverse digit is: {reverseDigit}");


            //sum of digit
            Console.WriteLine("enter number ");
            int number = int.Parse(Console.ReadLine());
            int sumDigit = 0;
            while (number > 0)
            {
                sumDigit += number % 10;
                number = number / 10;
            }
            Console.WriteLine($"Sum of digit is: {sumDigit}");

            //степень
            Console.WriteLine("enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b ");
            int b = int.Parse(Console.ReadLine());
            int result = a;
            for (int i = b; i > 1; i--)
            {
                result = result * a;
            }
            Console.WriteLine($"a в степени b = {result}");
            
            //Deposit
            Console.WriteLine("Enter the sum of deposit");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many mounths deposit lasts: ");
            int mounth = int.Parse(Console.ReadLine());
            double interest = 4;
            Console.WriteLine($"The interest is {interest} per mounth");

            
            for (int i = mounth; i > 0; i--)
            {
                sum = sum * 1.04;
            }
            Console.WriteLine($"The sum with interest is: {sum}");
            /*
            //MiddleDigit
            Console.WriteLine("enter digit1 ");
            int digit1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter digit2 ");
            int digit2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter digit3 ");
            int digit3 = int.Parse(Console.ReadLine());
                        
            if (digit1 > digit2 & digit1 < digit3 | digit1 > digit3 & digit1 < digit2)
                Console.WriteLine ( $"The Middle digit is {digit1}");
            else if (digit2 > digit1 & digit2 < digit3 | digit2 > digit3 & digit2 < digit1)
                Console.WriteLine($"The Middle digit is {digit2}");
            else if (digit3 > digit1 & digit3 < digit2 | digit3 > digit2 & digit3 < digit1)
                Console.WriteLine($"The Middle digit is {digit3}");
            else Console.WriteLine("There is no correct middle digit among these digits");
            Console.WriteLine();

            //ThreeDigitNumber
            Console.WriteLine ("Please enter three-digit number ");
            int threeDigitNumber = int.Parse (Console.ReadLine());

            digit1 = threeDigitNumber % 10;
            digit3 = threeDigitNumber / 100;
            digit2 = (threeDigitNumber - digit3 * 100) / 10;

            if (threeDigitNumber % 2 == 0)
                Console.WriteLine ($"The sum of digits is {digit1 + digit2 + digit3}");
            else
                Console.WriteLine ($"The multiplication of digits is {digit1 * digit2 * digit3}");
            Console.WriteLine();
            
            //Area
            Console.WriteLine ("Choose the figure: square, circle, rectangle, triangle");

            string figure = Console.ReadLine();
            figure = figure.ToLower();
            switch (figure)
            {
                case "square":
                    Console.WriteLine ("enter the side length");
                    double side = double.Parse (Console.ReadLine());
                    Console.WriteLine ($"Area of the square is: {side * side}");
                    break;
                case "circle":
                    Console.WriteLine("enter the radius length");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of the circle is: {Math.PI * radius * 2}");
                    break;
                case "rectangle":
                    Console.WriteLine("enter the length of first side");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter the length of first side");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of the rectangle is: {side1 * side2}");
                    break;
                case "triangle":
                    Console.WriteLine("enter the length of the side");
                    double side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter the length of the triangle height");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of the triangle is: {side3 * height / 2}");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
            Console.WriteLine();

            //Deposit
            Console.WriteLine ("Enter the sum of deposit");
            double sum = double.Parse (Console.ReadLine());
            Console.WriteLine ("Enter how many mounths deposit lasts: ");
            int mounth = int.Parse(Console.ReadLine());
            double interest = 4;
            Console.WriteLine($"The interest is {interest} per mounth");
                     
            Console.WriteLine($"The sum with interest is: {sum * Math.Pow(1 + interest/100, mounth)}");
            */


            //double footDistance = double.Parse(Console.ReadLine()); //0.305 metr
            //double metrDistance = double.Parse(Console.ReadLine());
            /*
            Console.WriteLine( "enter Speed meter/sec");
            double msSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("enter Speed km/h");
            double kmhSpeed = double.Parse(Console.ReadLine()); // *1000/3600
            
            if (msSpeed > kmhSpeed * 1000 / 3600)
            {
                Console.WriteLine ( $"max Speed is:{msSpeed}  meter/sec");
            }
            else
            {
                Console.WriteLine($"max Speed is:{kmhSpeed}  km/h");
            }
            */

            /*
            string s = Console.ReadLine();
            s = s.ToLower();
            switch (s)
            {
                case "monday": Console.WriteLine(1);
                    break;
                case "tuesday": Console.WriteLine(2);
                    break;
                case "wednesday": Console.WriteLine(3);
                    break;
                case "thursday": Console.WriteLine(4);
                    break;
                default : Console.WriteLine("incorrect input");
                    break;
            }
            */
            /*
            Console.WriteLine("enter season ");
            string season = Console.ReadLine();
            season = season.ToLower();
            switch (season)
            {
                case "spring": Console.WriteLine(" - March, Aprile, May");
                    break;
                case "summer": Console.WriteLine(" - June, July, August");
                    break;
                case "autumn": Console.WriteLine(" - September, October, November");
                    break;
                case "winter": Console.WriteLine(" - December, January, February");
                    break;
                default : Console.WriteLine("incorrect input");
                    break;
            }
            */
            /*
            Console.WriteLine("Please enter how macth money you want to spend ");
            double money = double.Parse ( Console.ReadLine() );
            
            Console.WriteLine("Sugar = 1$, bread = 2$, butter = 3$, coffee = 4$");
            Console.WriteLine("Choose some food");
            string food = Console.ReadLine();
            food = food.ToLower();
            
            Console.WriteLine("How match food you want to buy?");
            double howMatch = double.Parse(Console.ReadLine());
            
            switch (food)
            {
                case "sugar":
                    if (1 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} kg of sugar. It costs {1 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "bread":
                    if (2 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} bars of bread. It costs {2 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "butter":
                    if (3 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} bars of butter. It costs {3 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                case "coffee":
                    if (4 * howMatch <= money)
                        Console.WriteLine($" - You've bought {howMatch} g of coffe. It costs {4 * howMatch} $");
                    else Console.WriteLine("It's not enough. See you later");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
            */

        }
    }
}
