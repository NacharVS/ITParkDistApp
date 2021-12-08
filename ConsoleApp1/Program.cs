using System;
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
            //Среднее из трех чисел
            Console.Write("Введите три натуральных числа: ");
            int userNumber = Console.ReadLine().Split().Select(int.Parse).ToArray().Take(3);
            Console.WriteLine(userNumber);
            int firstDigit = int.Parse(userNumber) / 100;
            int secondDigit = (userNumber % 100) / 10;
            int thirdDigit = userNumber % 10;
            Console.WriteLine($"1 число: {firstDigit}");
            Console.WriteLine($"2 число: {secondDigit}");
            Console.WriteLine($"3 число: {thirdDigit}");
            if (firstDigit > secondDigit & firstDigit < thirdDigit)
                Console.WriteLine($"Среднее число: {firstDigit}");
            else
                if (secondDigit > firstDigit & secondDigit < thirdDigit)
                    Console.WriteLine($"Среднее число: {secondDigit}");
                else Console.WriteLine($"Среднее число: {thirdDigit}");
        }

    }
}
