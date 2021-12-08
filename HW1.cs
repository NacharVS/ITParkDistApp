using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)

        {
            //1. Вводиться 3 натуральных числа. Найти среднее из них. 

            Console.WriteLine("Enter three numbers to find the average");
            Console.Write("Enter first number ");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number ");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number ");
            int thirdnum = Convert.ToInt32(Console.ReadLine());

            if (firstnum > secondnum & firstnum > thirdnum)
            {
                
                if ((firstnum - secondnum) > (firstnum - thirdnum))
                {
                    Console.WriteLine($"The average number is  { thirdnum}");
                }
                else
                    Console.WriteLine($"The average number is {secondnum}");
            }
            else
            {
                if (secondnum > firstnum & secondnum > thirdnum)
                    if ((secondnum - firstnum) > (secondnum - thirdnum))
                    {
                        Console.WriteLine($"The average number is {thirdnum}");
                    }
                else
                        Console.WriteLine($"The average number is  {firstnum}");

                if (thirdnum > secondnum & thirdnum >firstnum)
                {
                    if ((thirdnum - secondnum) > (thirdnum - firstnum))
                    {
                        Console.WriteLine($"The average number is {firstnum}");
                    }
                    else
                        Console.WriteLine($"The average number is {secondnum}");
                }


               


                //2. Дано трехзначное число. Если оно четное, то найти сумму цифр, если оно нечетное, найти произведение.
                Console.Write("Hello!");
                Console.WriteLine("Enter the thre-digit number. If the number is even, then you will know sum of the digits. If the number is odd, you will know the product of the digits");
                int number = Convert.ToInt32(Console.ReadLine());

                int hundreds = number / 100;
                int dozens = number / 10 % 10;
                int units = number % 10;

                if ((number % 2) == 0)
                {
                    //even
                    Console.WriteLine($"The sum of the numbers = {hundreds + dozens + units}");
                }
                else
                    //odd
                    Console.WriteLine($"The product of the numbers = {hundreds * dozens * units}");


                //3. Написать программу, которая, в зависимости от выбора пользователя, предложит найти площадь геометрической фигуры. 

                Console.WriteLine("Select a geometric shape");

                Console.WriteLine("1. Square");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Trapeze");

                string choiseshape = Console.ReadLine();

                switch (choiseshape)
                {

                    case "1":
                        Console.WriteLine($"You have selected a square. Choose a method");
                        Console.WriteLine("1. by the ienght of the side");
                        Console.WriteLine("2. by the lenght of the diagonal");
                        string lside = "1";
                        string ldiagon = "2";
                        string method = Console.ReadLine();

                        if (method == lside)
                        {
                            Console.WriteLine("Enter the side lenght in centimeteres");
                            double sidelenghtsq = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"The area is {sidelenghtsq * sidelenghtsq}");

                        }
                        else
                        {
                            if (method == ldiagon)
                            {
                                Console.WriteLine("Enter the diagonale lenght in centimeteres");
                                double diagonlenghtsq = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"The area is {(diagonlenghtsq * diagonlenghtsq) / 2}");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine($"You have selected a circle. Enter the radius");
                        double rad = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area is {(rad * rad) * Math.PI}");
                        break;
                    case "3":
                        Console.WriteLine($"You have selected a triangle. Enter the side and height");
                        Console.WriteLine("Enter the side in centimeteres");

                        double basside = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the height in centimeteres");

                        double height = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"The area is {(basside / 2) * height}");
                        break;
                    case "4":
                        Console.WriteLine($"You have selected a trapeze.  Enter the median and height");
                        Console.WriteLine("Enter median in centimeteres");
                        double med = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height in centimeteres");
                        double heighttr = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area is {med * heighttr}");
                        break;



                }


                //4. Написать программу для вычисления процентов по вкладу (ставка составляет 4% в месяц). Пользователь вводит сумму вклада и количество месяцев. Проценты начисляются каждый месяц.

                Console.WriteLine("Enter the deposit amount");
                double dep = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number of mounths");
                double num = Convert.ToDouble(Console.ReadLine());
                double dsum = dep * (1 + ((0.04 / 12) * (12 * num)));
                double depinterest = dsum - dep;

                Console.WriteLine($"The total amount is {dsum}. Deposit interest is {depinterest}");

            }

            

        }

    }
}
