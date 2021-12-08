using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //1 задача:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Nubmer Max = " + a);
            else if (b > c)
                Console.WriteLine("Number Max = " + b);
            else
                Console.WriteLine("Number Max = " + c);
            //2 задача:
            Console.WriteLine("Insert in feets:");
            double feetDistance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); //0.305 meter
            Console.WriteLine("Insert in meters:");
            double meterDistance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double exchange = feetDistance * 0.305;
            if (exchange > meterDistance)
                Console.WriteLine("More is:" + feetDistance);
            else Console.WriteLine("More is:" + meterDistance);
            Console.ReadLine();*/
            //3 задача:
            /*Console.WriteLine("Insert in km/h:");
            double kmspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //0.305 meter
            Console.WriteLine("Insert in m/s:");
            double mspeed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double exchange = kmspeed * 0.277778;
            if (exchange > mspeed)
                Console.WriteLine("More is:" + kmspeed);
            else Console.WriteLine("More is:" + mspeed);
            Console.ReadLine();*/
            //4 задача
            /*Begin:
            Console.WriteLine("Input the season:");
            string s = Console.ReadLine();
            s=s.ToLower();
            switch(s)
            {
                case "winter":Console.WriteLine("December,January,February");
                    break;
                case "summer":
                    Console.WriteLine("June,July,August");
                    break;
                case "spring":
                    Console.WriteLine("March,May,April");
                    break;
                case "autumn":
                    Console.WriteLine("September,October,November");
                    break;
                /*case "friday":
                    Console.WriteLine(5);
                    break;
                case "saturday":
                    Console.WriteLine(6);
                    break;
                case "sunday":
                    Console.WriteLine(7);
                    break;
                default:Console.WriteLine("Incorrect season! Try again...");
                    goto Begin;*/
            //5 задача
            /*int bread = 10; //$ - cost
            int sugar = 20; //$ - cost
            int milk = 30; //$ - cost*/
            /*
            Console.Write("How money do you have?...: ");
            int allMoney=int.Parse(Console.ReadLine());
            Console.WriteLine("Choose product:");
            Console.WriteLine("1. Milk = 0.70 $");
            Console.WriteLine("2. Bread = 1.60 $");
            Console.WriteLine("3. Beef = 9.90 $");
            Console.WriteLine("4. Sugar = 1.40 $");
            Console.WriteLine("5. Cheese = 11.00 $");
            string productType = Console.ReadLine();
            Console.WriteLine($"How mach product do you need?");
            int amountOfProduct=int.Parse(Console.ReadLine());
            switch (productType)
            {
                case "1":
                    {
                        double sumMoney = 0.7 * amountOfProduct;
                        if (sumMoney <= allMoney)
                            Console.WriteLine($"Successful purchase =) (Your money: {allMoney} is enough to buy Milk for {sumMoney}$ Your change is {allMoney-sumMoney}$)");
                        else Console.WriteLine($"Not enough money! (Summ of all Milk: {sumMoney} more then your money: {allMoney}");
                    }
                    break;
                case "2":
                    {
                        double sumMoney = 1.6 * amountOfProduct;
                        if (sumMoney <= allMoney)
                            Console.WriteLine($"Successful purchase =) (Your money: {allMoney} is enough to buy Bread for {sumMoney}$ Your change is {allMoney - sumMoney}$)");
                        else Console.WriteLine($"Not enough money! (Summ of all Bread: {sumMoney} more then your money: {allMoney}");
                    }
                    break;
                case "3":
                    {
                        double sumMoney = 9.9 * amountOfProduct;
                        if (sumMoney <= allMoney)
                            Console.WriteLine($"Successful purchase =) (Your money: {allMoney} is enough to buy Beef for {sumMoney}$ Your change is {allMoney - sumMoney}$)");
                        else Console.WriteLine($"Not enough money! (Summ of all Beef: {sumMoney} more then your money: {allMoney}");
                    }
                    break;
                case "4":
                    {
                        double sumMoney = 1.4 * amountOfProduct;
                        if (sumMoney <= allMoney)
                            Console.WriteLine($"Successful purchase =) (Your money: {allMoney} is enough to buy Sugar for {sumMoney}$ Your change is {allMoney - sumMoney}$)");
                        else Console.WriteLine($"Not enough money! (Summ of all Sugar: {sumMoney} more then your money: {allMoney}");
                    }
                    break;
                case "5":
                    {
                        double sumMoney = 11.0 * amountOfProduct;
                        if (sumMoney <= allMoney)
                            Console.WriteLine($"Successful purchase =) (Your money: {allMoney} is enough to buy Chese for {sumMoney}$ Your change is {allMoney - sumMoney}$)");
                        else Console.WriteLine($"Not enough money! (Summ of all Cheese: {sumMoney} more then your money: {allMoney}");
                    }
                    break;
            */
            //1.Вводиться 3 натуральных числа. Найти среднее из них.
            //(Пример ввода/вывода: 7 66 5/Результат 7; Пример ввода/вывода: 2 4 8/Результат 4)
            /*Console.Write("Введите три натуральных числа через пробел: ");
            string inputNumber=Console.ReadLine();
            string[] tokens = inputNumber.Split(' ');
            int firstDigit=int.Parse(tokens[0]);
            int secondDigit = int.Parse(tokens[1]);
            int thirdDigit = int.Parse(tokens[2]);
            if ((firstDigit > secondDigit & firstDigit <= thirdDigit)||(firstDigit>thirdDigit & firstDigit<=secondDigit))
                Console.WriteLine($"Среднее число: {firstDigit}");
            else
                if ((secondDigit >= firstDigit & secondDigit <= thirdDigit)||(secondDigit >= thirdDigit & secondDigit <= firstDigit))
                    Console.WriteLine($"Среднее число: {secondDigit}");
                else Console.WriteLine($"Среднее число: {thirdDigit}");*/
            //2.Дано трехзначное число. Если оно четное, то найти сумму цифр, если оно нечетное, найти произведение.
            //(Пример ввода/вывода: 123/Результат 6; Пример ввода/вывода: 666 /Результат 18)
            /*Console.Write("Введите трехзначное число: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int firstDigit = inputNumber / 100;
            int secondDigit = (inputNumber % 100)/10;
            int thirdDigit = inputNumber % 10;
            if (inputNumber % 2 <= 0)
                Console.WriteLine($"Четное. Сумма цифр: {firstDigit+secondDigit+thirdDigit}");
            else Console.WriteLine($"Нечетное. Произведение цифр: {firstDigit * secondDigit * thirdDigit}");*/
            //3. Написать программу, которая, в зависимости от выбора пользователя, предложит найти площадь геометрической фигуры. 
            //(Пример работы программы: Выберите фигуру: square, введите длину одной стороны квадрата: 4, Площадь квадрата: 16)

        }

    }
}
