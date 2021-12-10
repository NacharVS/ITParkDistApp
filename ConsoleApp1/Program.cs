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
            /*Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1.квадрат");
            Console.WriteLine("2.прямоугольник");
            Console.WriteLine("3.параллелограмм");
            Console.WriteLine("4.круг");
            Console.WriteLine("5.треугольник");
            var geometricFigure = Console.ReadLine();
            switch (geometricFigure)
            {
                case "1":
                    {
                        Console.Write("Введите длину стороны квадрата: ");
                        double side = double.Parse(Console.ReadLine());
                        double area = Math.Pow(side, 2);
                        Console.WriteLine($"Площадь квадрата: {area}");
                    }
                    break;
                case "2":
                    {
                        Console.Write("Введите длину одной стороны прямоугольника: ");
                        double side1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину другой стороны прямоугольника: ");
                        double side2 = double.Parse(Console.ReadLine());
                        double area = side1*side2;
                        Console.WriteLine($"Площадь прямоугольника: {area}");
                    }
                    break;
                case "3":
                    {
                        Console.Write("Введите длину одной стороны параллелограмма: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину высоты, опущенной на указанную сторону: ");
                        double high = double.Parse(Console.ReadLine());
                        double area = side * high;
                        Console.WriteLine($"Площадь параллелограмма: {area}");
                    }
                    break;
                case "4":
                    {
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI * Math.Pow(radius,2);
                        Console.WriteLine($"Площадь круга: {area}");
                    }
                    break;
                case "5":
                    {
                        Console.Write("Введите длину одной стороны треугольника:");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Введите длину высоты, опущенной на указанную сторону:");
                        double high = double.Parse(Console.ReadLine());
                        double area = (side * high)/2;
                        Console.WriteLine($"Площадь треугольника: {area}");
                    }
                    break;
            }*/
            //4. Написать программу для вычисления процентов по вкладу (ставка составляет 4% в месяц).
            //Пользователь вводит сумму вклада и количество месяцев. Проценты начисляются каждый месяц.
            //(Пример ввода / вывода: 4000 4 Результат: 4679,43424)
            /*Console.Write("Введите сумму вклада: ");
            double depositSum = double.Parse(Console.ReadLine());
            Console.Write("Введите срок вклада в целых месяцах: ");
            int depositTerm=int.Parse(Console.ReadLine());
            double depositResult = depositSum*(Math.Pow(1.04,depositTerm));
            Console.WriteLine($"Итоговая сумма к концу вклада: {depositResult}");*/
            //----------------------------------------------------
            //Лекция 3 Циклы.
            //1 pelmen = 2 testo+1 farsh
            /*int testo = int.Parse(Console.ReadLine());
            int farsh = int.Parse(Console.ReadLine());
            int pelmenCount = 0;
            //int pelmeneyNeeded = int.Parse(Console.ReadLine());
            for (int i = testo + farsh; i / 3 >= 1; i = i - 3)
            {
                if (testo >= 2 & farsh >= 1)
                {
                    pelmenCount++;
                    testo = testo - 2;
                    farsh = farsh - 1;
                }
                else break;
                Console.WriteLine($"Ptlmeney: {pelmenCount}, testo: {testo}, farsh: {farsh}");
            }*/
            /*int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
                
            }
            Console.WriteLine(result);*/
            //-----------------------------------------------------
            /*Console.Write("Введите сумму вклада: ");
            double depositSum = double.Parse(Console.ReadLine());
            Console.Write("Введите срок вклада в целых месяцах: ");
            int depositTerm = int.Parse(Console.ReadLine());
            double depositResult=0;
            for (int i = 0; i <= depositTerm; i++)
            {
                depositResult = depositSum + (depositSum * 0.04);
            }

            Console.WriteLine($"Итоговая сумма к концу вклада: {depositResult}");*/
            //---------------------
            /*Console.Write("Введите число, a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите степень, b: ");
            int b = int.Parse(Console.ReadLine());
            int r = 1;
            for (int i=0; i<b; i++)
            {
                r = r * a;
            }
            Console.WriteLine($"A в степени B равно: {r}");*/
            //-------------------------------------
            /*int a = int.Parse(Console.ReadLine());
            int sum = 0;
            //Console.WriteLine(c);
            for (int i = a; i >0; i=i/10)
            {
                sum += a%10;
                a=a / 10;
            }
            Console.WriteLine(sum);*/
            //-------------------------------------
            /*Console.WriteLine("Введите число, а мы найдем сумму его цифр: ");
            string a = Console.ReadLine();
            int b = a.Length;
            double sum = 0;
            for (int i = 0; i <b; i++ )
            {
                sum += Convert.ToInt32(a[i]);//Char.GetNumericValue(a[i]);//sum +=(a[i]-'0');
            }
            Console.WriteLine(sum);*/
            //------------------------
            /*int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);*/
            /*int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum = sum*10 + a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);*/
            //------------------------------------
            /*for (int i = 2; i < 10; i=i+2)
            {
                for (int j = -3; j < 3; j++)
                {
                    if (j == 0) break;
                    else
                    Console.WriteLine((double)(i/j));
                }
                Console.WriteLine();
            }*/

            /*int summ = int.Parse(Console.ReadLine());
            for (int i = 1; i < 999; i++)
            {
                if (summ == i % 10 + i / 100 + i / 10 % 10)
                {
                    Console.WriteLine($"{i / 100} {i / 10 % 10} {i % 10}");
                }
            }*/
            int combinations=0;
            int summ = int.Parse(Console.ReadLine());
            for (int i = 0; i <=9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k= 0; k <= 9; k++)
                    {
                        if (i + j + k == summ && i!=j && j!=k && i!=k &&)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine($"Count: {combinations}");
            //------------------------ for и while
            /*int n = int.Parse(Console.ReadLine());
            int count=0;
            for (int i = 1; i <=n; i++)
            {
                int a = i;
                while (a > 0)
                {
                    if (a % 10 == 7)// i == 7 ||  || i / 10 == 7)
                        count++;
                    a = a / 10;
                }
            }
            Console.WriteLine($"Count: {count}");*/
        }

        // сократить кол-во комбинаций
//вывести представление числаN в в виде простых множетелей
//input 6 output 2 3
//input 30 output 2 3 5
// input 16 output 2 2 2 2
// дана числовая последовательность от 1 до N Найти такое число сумма цифр кторого будет наибольшей среди всей последовательности.
//вывести само число и его сумму цифр
//input (1 до n) 20 output 19 10
//input 44 output 39 12
    }
}
