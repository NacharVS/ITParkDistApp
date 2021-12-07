using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                //Output a list of shapes to the console.
                Console.WriteLine("Select the shape number from the list:");
                Console.WriteLine("1. square;");
                Console.WriteLine("2. rectangle;");
                Console.WriteLine("3. right triangle;");
                Console.WriteLine("4. circle;");
                Console.WriteLine("5. trapezoid.");

                int numberOfShape = int.Parse(Console.ReadLine());
                double areaOfFigure;

                //Depending on the number of the figure, we calculate the area of the figure.
                switch (numberOfShape)
                {
                    //S square.
                    case 1:
                        Console.WriteLine("Enter the length of the side of the square:");
                        double sideSquare = double.Parse(Console.ReadLine());

                        areaOfFigure = Math.Pow(sideSquare, 2);

                        Console.WriteLine($"The area of the square with a side: {sideSquare} is: {areaOfFigure}.");
                        break;

                    //S rectangle.
                    case 2:
                        Console.WriteLine("Enter the adjacent sides of the rectangle:");
                        double sideRectangle1 = double.Parse(Console.ReadLine());
                        double sideRectangle2 = double.Parse(Console.ReadLine());

                        areaOfFigure = sideRectangle1 * sideRectangle2;

                        Console.WriteLine($"The area of the rectangle on one side: {sideRectangle1} and the other side: {sideRectangle2} is: {areaOfFigure}.");
                        break;

                    //S right triangle.
                    case 3:
                        Console.WriteLine("Enter the right triangle catheters:");
                        double catheter1 = double.Parse(Console.ReadLine());
                        double catheter2 = double.Parse(Console.ReadLine());

                        areaOfFigure = (catheter1 * catheter2) / 2;

                        Console.WriteLine($"The area of the right triangle on one catheter: {catheter1} and the other catheter: {catheter2} is: {areaOfFigure}.");
                        break;

                    //S circle.
                    case 4:
                        Console.WriteLine("Enter the radius of the circle:");
                        double radius = double.Parse(Console.ReadLine());

                        areaOfFigure = Math.PI * Math.Pow(radius, 2);

                        Console.WriteLine($"The area of the circle with the radius: {radius} is: {areaOfFigure}.");
                        break;

                    //S trapezoid.
                    case 5:
                        Console.WriteLine("Enter the bases of the trapezoid:");
                        double basesTrapezoid1 = double.Parse(Console.ReadLine());
                        double basesTrapezoid2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the trapezoid:");
                        double heightTrapezoid = double.Parse(Console.ReadLine());

                        areaOfFigure = (basesTrapezoid1 + basesTrapezoid2) / 2 * heightTrapezoid;

                        Console.WriteLine($"The area of a trapezoid on one base: {basesTrapezoid1}, the other base: {basesTrapezoid2} and the height: {heightTrapezoid} is: {areaOfFigure}.");
                        break;

                    //Error.
                    default:
                        Console.WriteLine("Figure number input error");
                        break;
                }
            }
        }
    }
}
