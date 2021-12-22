using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выбирите тип входа:Client/Admin");
            string client = Console.ReadLine();

            if (client == "Client")
            {
                Console.WriteLine("Вы зашли как клиент");
                Console.Write("Введите сумму: ");
                double allMoney = double.Parse(Console.ReadLine());
                double Balans;


                while (true)
                {


                    Console.WriteLine("Выберите продукт:");
                    Console.WriteLine("1. Молоко = 0.50 $");
                    Console.WriteLine("2. Хлеб = 2.00 $");
                    Console.WriteLine("3. Куринное филе = 7.13 $");
                    Console.WriteLine("4. Сок = 1.00 $");
                    Console.WriteLine("5. Плавленный сыр = 6.00 $");
                    string productType = Console.ReadLine();
                    Console.WriteLine($"Потвердите ваш выбор");
                    int amountOfProduct = int.Parse(Console.ReadLine());



                    switch (productType)
                    {
                        case "1":
                            {
                                double sumMoney = 0.50 * amountOfProduct;
                                if (sumMoney <= allMoney)
                                {

                                    Console.WriteLine($"Ваша выбор:Молоко.Сумма покупки:0,50$.Потвердить покупку?(Y/N)");
                                    string approveProduct = Console.ReadLine();
                                    switch (approveProduct)
                                    {
                                        case "Y":
                                            Console.WriteLine("Вы подтвердили покупку");
                                            Balans = allMoney - sumMoney;
                                            Console.WriteLine("Ваш баланс составляет:" + Balans);




                                            Console.WriteLine("Хотите преобрести кое-что еще?");
                                            switch (approveProduct)
                                            {
                                                case "N":
                                                    break;
                                            }
                                            break;

                                        case "N":
                                            {
                                                Console.WriteLine("Отказ  от покупки");
                                                break;
                                            }


                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"У вас недостаточно средств");
                                }
                            }
                            break;
                        case "2":
                            {
                                double sumMoney = 2.00 * amountOfProduct;
                                if (sumMoney <= allMoney)
                                {
                                    Console.WriteLine($"Ваша выбор:Хлеб.Сумма покупки:2,00$.Потвердить покупку?(Y/N)");
                                    string approveProduct = Console.ReadLine();
                                    switch (approveProduct)
                                    {
                                        case "Y":
                                            Console.WriteLine("Вы подтвердили покупку");

                                            Balans = allMoney - sumMoney;
                                            Console.WriteLine("Ваш баланс составляет:" + Balans);

                                            Console.WriteLine("Хотите преобрести кое-что еще?");
                                            switch (approveProduct)
                                            {
                                                case "N":
                                                    break;
                                            }
                                            break;
                                        case "N":
                                            {
                                                Console.WriteLine("Отказ  от покупки");
                                                break;
                                            }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"У вас недостаточно средств");

                                }
                            }
                            break;
                        case "3":
                            {
                                double sumMoney = 7.13 * amountOfProduct;
                                if (sumMoney <= allMoney)
                                {
                                    Console.WriteLine($"Ваша выбор:Куринное филе.Сумма покупки:7,13$.Потвердить покупку?(Y/N)");
                                    string approveProduct = Console.ReadLine();
                                    switch (approveProduct)
                                    {
                                        case "Y":
                                            Console.WriteLine("Вы подтвердили покупку");

                                            Balans = allMoney - sumMoney;
                                            Console.WriteLine("Ваш баланс составляет:" + Balans);

                                            Console.WriteLine("Хотите преобрести кое-что еще?");
                                            switch (approveProduct)
                                            {
                                                case "N":
                                                    break;
                                            }

                                            break;
                                        case "N":
                                            {
                                                Console.WriteLine("Отказ  от покупки");
                                                break;
                                            }
                                    }
                                }

                                else
                                {
                                    Console.WriteLine($"У вас недостаточно средств");
                                }
                            }
                            break;
                        case "4":
                            {
                                double sumMoney = 1.00 * amountOfProduct;
                                if (sumMoney <= allMoney)
                                {
                                    Console.WriteLine($"Ваша выбор:Вишнёвый сок.Сумма покупки:1,00$.Потвердить покупку?(Y/N)");
                                    string approveProduct = Console.ReadLine();
                                    switch (approveProduct)
                                    {
                                        case "Y":
                                            Console.WriteLine("Вы потврердили покупку");
                                            Balans = allMoney - sumMoney;
                                            Console.WriteLine("Ваш баланс составляет:" + Balans);

                                            Console.WriteLine("Хотите преобрести кое-что еще?");
                                            switch (approveProduct)
                                            {
                                                case "N":
                                                    break;
                                            }

                                            break;
                                        case "N":
                                            {
                                                Console.WriteLine("Отказ  от покупки");
                                                break;
                                            }
                                    }
                                }

                                else
                                {
                                    Console.WriteLine($"У вас недостаточно средств");
                                }
                            }
                            break;
                        case "5":
                            {
                                double sumMoney = 6.00 * amountOfProduct;
                                if (sumMoney <= allMoney)
                                {
                                    Console.WriteLine($"Ваша выбор:Плавленный сыр.Сумма покупки:6,00$.Потвердить покупку?(Y/N)");
                                    string approveProduct = Console.ReadLine();
                                    switch (approveProduct)
                                    {
                                        case "Y":
                                            Console.WriteLine("Вы подтвердили покупку");

                                            Balans = allMoney - sumMoney;
                                            Console.WriteLine("Ваш баланс составляет:" + Balans);

                                            Console.WriteLine("Хотите преобрести кое-что еще?");
                                            switch (approveProduct)
                                            {
                                                case "N":
                                                    break;
                                            }

                                            break;
                                        case "N":
                                            {
                                                Console.WriteLine("Отказ  от покупки");
                                                break;
                                            }
                                    }
                                }

                                else
                                {
                                    Console.WriteLine($"У вас недостаточно средств");
                                }
                            }
                            break;



                    }



                }



            }
            else
            {
                

                Console.WriteLine("Вы зашли как администратор");

                
                while (true)
                {
                    Console.WriteLine("Вы хотите добавить товар или удалить Добавить/Удалить ");
                    string choice2 = Console.ReadLine();
                    //choice2 = choice2.ToLower();
                    Console.WriteLine("Выберите продукт чтобы удалить");
                    
                    Console.WriteLine("1. Молоко = 0.50 $");
                    Console.WriteLine("2. Хлеб = 2.00 $");
                    Console.WriteLine("3. Куринное филе = 7.13 $");
                    Console.WriteLine("4. Сок = 1.00 $");
                    Console.WriteLine("5. Плавленный сыр = 6.00 $");
                    string productType = Console.ReadLine();
                    switch (productType)
                    {
                        case "Удалить":

                            break;

                        //case "Добавить":
                        //    Console.WriteLine("Выберите продукт:");
                        //    Console.WriteLine("1. Печенье = 3,00 $");
                        //    Console.WriteLine("2. Торт = 2.00 $");
                        //    Console.WriteLine("3. Круасан = 5.73 $");
                        //    Console.WriteLine("4. Квас = 1.10 $");
                        //    Console.WriteLine("5. стейк = 8.00 $");


                        //    string tovar2 = (Console.ReadLine());

                        //    break;
                    }

                    //Console.WriteLine("Хотите продолжить?(Y/N)");
                    //string choice3 = Console.ReadLine();
                    //choice3 = choice3.ToLower();
                    //if (choice3 == "N")
                    //{
                    //    break;
                    //}


                }










            }
        }


    }
}
