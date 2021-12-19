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
            //------------------------ for и while
            /*          int n = int.Parse(Console.ReadLine());
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
                        Console.WriteLine($"Count: {count}");
            */
            //1 задача. Нахождение комбинаций 3х-значного кодового замка по его сумме:
            /*
             * Console.Write("Введите сумму цифр кодовой комбинации замка: ");
            int combinations = 0;
            int summ = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i + j + k == summ && i < j && j < k)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine($"Всего комбинаций: {combinations}");
            */
            //2 задача. Простые множители.
            /*        
                      Console.Write("Введите число для поиска его простых множителей: ");
                      int number = int.Parse(Console.ReadLine());
                      Console.Write($"{number} = 1");
                      for (int i = 0; number % 2 == 0; number /= 2)
                      {
                          Console.Write(" * 2");
                      }
                      for (int i = 3; i <= number;)
                      {
                          if (number % i == 0)
                          {
                              Console.Write($" * {i}");
                              number /= i;
                          }
                          else
                          {
                              i += 2;
                          }
                      }*/
            //второй вариант нахождения простых множителей (разбор с Вадимом)
            /*int number = int.Parse(Console.ReadLine());
            int divider = 2;
            while (number > 1)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (number % divider == 0)
                    {
                        number = number / divider;
                        Console.WriteLine(divider);
                    }
                    else divider++;
                }
            }*/
            //3 задача.Нахождение максимальной суммы цифр в числовом ряде:
            /*Console.Write("Введите конечное число N ряда 1...N: ");
            int sequence = int.Parse(Console.ReadLine());
            int numberOfMaxSum = 0;
            int maximumSum = 0;
            for (int i = 1; i <= sequence; i++)
            {
                int numberOfSequence = i;
                int sumOfNumber = 0;
                for (int j = numberOfSequence; j > 0; j = j / 10)
                {
                    sumOfNumber += numberOfSequence % 10;
                    numberOfSequence = numberOfSequence / 10;
                }
                //Console.WriteLine($"Число ряда: {i} имеет сумму цифр: {sumOfNumber}");
                if (sumOfNumber > maximumSum)
                {
                    maximumSum = sumOfNumber;
                    numberOfMaxSum = i;
                }
            }
            Console.WriteLine($"В заданном ряде (1-{sequence}) число {numberOfMaxSum} имеет максимальную сумму цифр: {maximumSum}");
            */
            //HOMEWORK
            //(V)1.Сократить кол-во комбинаций.
            //(V)2.Вывести представление числа N в виде простых множетелей.
            //      input 6 output 2 3
            //      input 30 output 2 3 5
            //      input 16 output 2 2 2 2
            //(V)3.Дана числовая последовательность от 1 до N;
            //      Найти такое число сумма цифр которого будет наибольшей среди всей последовательности;
            //      Вывести само число и его сумму цифр.
            //      input (1 до n) 20 output 19 10
            //      input 44 output 39 12
            //Лекция 4. Коллекции, массивы.
            /*int[] array = new int[5];
            int[] array2 = new int[9];
            Console.WriteLine(array2.Length);
            array[0] = 15;
            array2[0] = 77;
            Console.WriteLine($"{array[0]} {array2[0]} {array2[1]}");*/
            //простая формула: [] - кол-во элементов массива. [9] - 9 элементов, но последний 8, т.к. начало с нуля.
            //macIndex=Length-1
            //класс random
            /* int[] array = new int[10];
             Random random = new Random();
             /*array[0]=random.Next(100);//одно значение в скобке - от 1 до этого значения. 2 цифры - от первой до второй.
             Console.WriteLine(array[0]);
             int sum = 0;
             int max = int.MinValue;
             int min = int.MaxValue;*/
            //заполнение массива и подсчет суммы элементов. Нахождение max/min.
            /*for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                sum += array[i];
                Console.Write($"{array[i]} ");
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма: {sum}, max: {max}, min: {min}") ;
            */
            //поиск элементов больше предыдущего
            /*Console.Write("Больше предыдущего: ");
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i+1] > array[i])
                Console.Write($"{array[i+1]} ");
            }*/
            //цикл foreach - только для чтения.
            /*foreach (int item in array)//item - переменная, может быть любая.
            {
                Console.WriteLine(item);
            }*/
            /*Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(array[5]);*/
            //8 2  4 65 2 3 77 8
            //4 65 3 77
            //Сортировка массива. Пузырьковый метод.
            /*int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int p = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = p;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            */
            //двумерные массивы
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd=new Random();
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }*/
            //найти сумму элементов строк
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine();
            }*/
            //Найти сумму строки и отсортировать суммы
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random rnd = new Random();
            int[] sumInRow = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(2);
                    sumInRow[i] += array[i, j];
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sumInRow.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sumInRow[i]}");
            }
            for (int j = 0; j < sumInRow.Length - 1; j++)
            {
                for (int i = 0; i < sumInRow.Length - 1 - j; i++)
                {
                    if (sumInRow[i] > sumInRow[i + 1])
                    {
                        int p = sumInRow[i + 1];
                        sumInRow[i + 1] = sumInRow[i];
                        sumInRow[i] = p;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sorted: ");
            foreach (var item in sumInRow)
            {
                Console.Write($"{item} ");
            }
            */
            //ЛИСТЫ
            /*List<int> list = new List<int> ();
            list.Add(5);
            list.Add(323);
            list.Add(2);
            list.Add(432);
            list.Add(342);
            list.Add(6556);
            list.Add(222);
            list.Add(43);
            if (list.Contains(222))
                Console.WriteLine(list.IndexOf(222));
             foreach (int item in list)
             {
                 Console.WriteLine(item);
             }
            Console.WriteLine(list[1]);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf(43));
            list.Remove(2);
            /*
            Задание: в задачке про каталог товаров - создать каталог (наименование и цена за единицу).
            Должна быть возможность добавления новых товаров.
            Покупка нескольких товаров и удаление (админ).
            После сессии админа - войти под админом или клиентом. Если клиент - список товаров обновлен. (ввод товара хоть
            цифра, хоть строка) (ввод наименования и количества товаров) 
            Организовать подсчет общей стоимости покупки, проверку на наличие достаточной
            суммы денег. Если покупка прошла - вывести полный список купленных товаров и их стоимость.
            Корзина покупок - список
            Проверка денег - ифы
            Работа между переключениями админ/клиент - свич.
            Покупка - может быть 1 товар или несколько.
            */
            /*List<string> product = new List<string>();
            product.Add("Молоко");
            product.Add("Хлеб");
            product.Add("Говядина");
            product.Add("Сахар");
            product.Add("Сыр");
            List<double> coast = new List<double>();
            coast.Add(39.70);
            coast.Add(29.60);
            coast.Add(318.90);
            coast.Add(68.40);
            coast.Add(111.00);
            string mode = "";
            while (mode != "в")
            {
                Console.Write("Админ(а)/Клиент(к)/Выход(в)?: ");
                mode = Console.ReadLine();
                switch (mode)
                {
                    case "а":
                        {
                            Console.WriteLine("Текущий список товаров:");
                            for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                            {
                                Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                            }
                            Console.Write("Добавить или удалить товары?(+/-): ");
                            string editMode = Console.ReadLine();
                            switch (editMode)
                            {
                                case "+":
                                    {
                                        string exit = "д";
                                        while (exit != "н")
                                        {
                                            Console.Write("Наименование добавляемой позиции?: ");
                                            string newProduct = Console.ReadLine();
                                            product.Add(newProduct);
                                            Console.Write($"Цена в р. за кг. '{newProduct}': ");
                                            double coastNewProduct = double.Parse(Console.ReadLine());
                                            coast.Add(coastNewProduct);
                                            Console.Write("Продолжить добавление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                                                {
                                                    Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                                                }
                                                break;
                                            }
                                            else if (exit == "д") continue;
                                            else Console.WriteLine("Ошибка ввода: только 'д' или 'н'");
                                        }
                                    }
                                    break;
                                case "-":
                                    {
                                        string exit = "д";
                                        while (exit != "н")
                                        {
                                            Console.Write("Что удаляем?(№): ");
                                            int delProductNumber = int.Parse(Console.ReadLine());
                                            string delProduct = product[delProductNumber - 1];
                                            int indexRemove = product.IndexOf(delProduct);
                                            product.Remove(delProduct);
                                            coast.Remove(indexRemove);
                                            Console.Write("Продолжить удаление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                                                {
                                                    Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                                                }
                                                break;
                                            }
                                            else Console.Write(" Только 'д' или 'н'");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "к":
                        {
                            double amountOfPurchase = 0;
                            Console.Write("Сколько у вас денег на покупки?: "); //запрос имеющейся суммы денег
                            int allMoney = int.Parse(Console.ReadLine());
                            Console.WriteLine("Список продуктов:");
                            for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                            {
                                Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                            }
                            List<double> shoppingList = new List<double>();
                            List<string> shoppingListProduct = new List<string>();
                            int index = -1;
                            string exit = "д";//складываем покупки в корзину
                            while (exit != "н")
                            {
                                Console.Write("Какой продукт положить в корзину?(№): ");
                                int productTypeNumber = int.Parse(Console.ReadLine());
                                string productType = product[productTypeNumber - 1];
                                shoppingListProduct.Add(productType);
                                Console.Write($"Сколько '{productType}' вам нужно?: ");
                                int amountOfProduct = int.Parse(Console.ReadLine());
                                if (product.Contains(productType))
                                {
                                    index = product.IndexOf(productType);
                                    shoppingList.Add(amountOfProduct * coast[index]);
                                    Console.Write("Продолжить покупки?(д/н): ");
                                    exit = Console.ReadLine();
                                    if (exit == "н") break;
                                }
                            }
                            //печать корзины
                            Console.WriteLine("Ваша корзина покупок:");
                            for (int i=0; i<shoppingList.Count;i++)
                            {
                                Console.WriteLine($" {i+1}.'{shoppingListProduct[i]}' на сумму: {shoppingList[i]} р.");
                            }
                            //подсчет суммы корзины
                            for (int i = 0; i < shoppingList.Count; i++)
                            {
                                amountOfPurchase += shoppingList[i];
                            }
                            Console.WriteLine($"Сумма вашей корзины: {amountOfPurchase} р.");
                            if (amountOfPurchase <= allMoney)
                                Console.WriteLine($"Удачная покупка! (Ваших денег: {allMoney} р. достаточно для покупок на {amountOfPurchase} р. Сдача: {allMoney - amountOfPurchase} р.)");
                            else Console.WriteLine($"Не хватает денег! (Сумма покупок: {amountOfPurchase} р. больше, чем у вас денег: {allMoney} р.");
                        }
                        break;
                }
            }*/
            //2й варант магазина (разбирали с Вадимом)
            /*List<string> products = new List<string>() { "Bread", "Milk" };
            List<double> prices=new List<double>() { 50,50};
            Console.WriteLine("Client/Admin");
            string s=Console.ReadLine();
            if (s == "c")
            {
                Console.WriteLine("Enter money:");
                while (true)
                {
                    double money = 2000;
                    Console.WriteLine("Our list:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                    }
                    Console.Write("make your choice(1,2,3...):");
                    string clientChoice = Console.ReadLine();
                    List < double > cart= new List<double>();
                    int countOfProduct=0;
                    switch (clientChoice)
                    {
                        case "1":
                            {
                                Console.WriteLine("Enter count for Bread:");
                                cart.Add(prices[0] * countOfProduct);
                            }
                            break;
                    }
                    Console.WriteLine("Something else?(Y/N)");
                    clientChoice = Console.ReadLine();
                    if (clientChoice == "N")
                    {
                        break;
                    }
                }
                double summ = 0;
                for (int i = 0; i < cart.Count; i++)
                {
                    summ += cart[i];
                }
            }
            else 
            {
                Console.WriteLine("admin");
            }
            */
            // 1 меньше чем вторая матрица (2 мерный массив), сложить их. Матрицы могут быть одна больше или другая.
            // Сначала найти какая больше матрица.
            //Console.WriteLine("Введите размерность массива A:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите размерность массива B:");
            //int b = int.Parse(Console.ReadLine());
            //int[,] array1 = new int[a, a];
            //int[,] array2 = new int[b, b];
            //Random rnd = new Random();
            //Console.WriteLine("Массив A:");
            ////заполняем рандом в массив A
            //for (int i = 0; i < array1.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        array1[i, j] = rnd.Next(4);
            //        Console.Write($"{array1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Массив B:");
            ////заполняем рандом в массив B
            //for (int i = 0; i < array2.GetLength(0); i++) //GetLengt(0) - количестов строк, (1) - кол-во строк.
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        array2[i, j] = rnd.Next(4);
            //        Console.Write($"{array2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            ////проверяем какой массив меньше
            //if (a < b)
            //{
            //    int[,] array3 = new int[b, b];
            //    for (int i = 0; i < b; i++)
            //    {
            //        for (int j = 0; j < b; j++)
            //        {
            //            if (i < a && j < a) array3[i, j] = array1[i, j] + array2[i, j];//складываем массивы до размерности меньшего A
            //            else array3[i, j]= array2[i, j];//остальное просто копируем в новый массив
            //        }

            //    }
            //    //выводим сумму массивов
            //    Console.WriteLine("Массив A+B:");
            //    for (int i = 0; i < array3.GetLength(0); i++) 
            //    {
            //        for (int j = 0; j < array3.GetLength(1); j++)
            //        {
            //            Console.Write($"{array3[i, j]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else 
            //{
            //    int[,] array3 = new int[a, a];
            //    for (int i = 0; i < a; i++)
            //    {
            //        for (int j = 0; j < a; j++)
            //        {
            //            if (i < b && j < b) array3[i, j] = array1[i, j] + array2[i, j];//складываем массивы до размерности меньшего B
            //            else array3[i, j] = array1[i, j];//остальное просто копируем в новый массив
            //        }

            //    }
            //    //выводим сумму массивов
            //    Console.WriteLine("Массив A+B:");
            //    for (int i = 0; i < array3.GetLength(0); i++) 
            //    {
            //        for (int j = 0; j < array3.GetLength(1); j++)
            //        {
            //            Console.Write($"{array3[i, j]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            // 2 9
            // 3 7

            // 1 2 3 4
            // 8 7 5 2
            // 3 4 6 7
            // 6 3 7 4
            //5 лекция. Методы
            /*ArrayGeneration();
            Console.WriteLine();
            Console.WriteLine();
            ArrayGeneration2();*/
            /*Summ(int.Parse("5"),3);
            Summ(int.Parse(Console.ReadLine()), 3);*/
            //string - ссылочный тип. Все остальное - значимые типы (цифры+char). Стек - там хранится ссылка на строку,
            //а сама строка в другом месте ...
            //входящим параметром метод не оперирует - передается только его копия.
            //чтобы оперировать параметром - указывается перед параметром ref
            /*int x = 5;
            Summ(ref x, 6);
            Console.WriteLine(x);
            Console.WriteLine(Summ1(5, 6));*/
            //массив всегда передается в метод по ссыдке
            /*int[,] mass = new int[7,7];
            ArrayGeneration2(mass);
            Console.WriteLine();
            Console.Write("index?:");
            int index= int.Parse(Console.ReadLine());
            Console.WriteLine();*/
            //Console.WriteLine($"element {index} {mass[index-1]}");
            //задча. берем 2 массива одномерных. 3*6 и 8*3.
            // сложить потовряющие индексы в массиве
            // 4 6 8 9 2
            // 2 1 5 7 3

            // 1 1 2
            // 7 8 9
            // 3 1 2
            // 1 1 1
            // 6 5 8

            // 5 7 10
            // 9 9 14

            // 5 7 10 9 2
            // 9 9 14 7 3
            // 3 1 2 0 0
            // 1 1 1 0 0 
            // 6 5 8 0 0
            //6 лекция. Sorting
            int[] array = new int[10];
            int[,] array1 = new int[10, 5];
            ArrayGeneration(array1, 20);
            Console.WriteLine();
            ArrayGeneration(array, -100, 100);
        }
        static void Summ(params int[] numbers)
        {
            int summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }
            Console.WriteLine(summ);
        }
        static void Multiplicationtable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        static void Summ(int a, int b)
        {
            Console.WriteLine($"summ int {a + b}");
        }

        static void Summ(double a, double b)
        {
            Console.WriteLine($"summ double {a + b}");
        }
        static void Summ(long a, long b)
        {
            Console.WriteLine($"summ long {a + b}");
        }
        static void Summ(string a, string b)
        {
            Console.WriteLine($"concat string {a + b}");
        }

        static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);

                Console.Write(array[i] + " ");
            }
        }

        static void ArrayGeneration(int[] array, int minValue, int maxValue)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);

                Console.Write(array[i] + " ");
            }
        }

        static void ArrayGeneration(int[,] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(2);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ArrayGeneration(int[,] mass, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    mass[i, j] = rnd.Next(maxValue);

                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ArraySorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buff = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buff;
                    }
                }
            }
        }
        static void ArraySortingDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int buff = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buff;
                    }
                    else
                    {
                        ArraySorting(array);
            }
                }
            }

        }
        /*static void ArrayGeneration(int[] array)
        {
            Random rnd = new Random();
            //int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write(array[i] + " ");
            }
        }*/
        static void ArrayGeneration2(int[,] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(100);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Summ(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }
        static int Summ1(int a, int b)
        {
            return a + b;
        }
    }
}
