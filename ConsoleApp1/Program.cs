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
            string client=Console.ReadLine();
            string admin=Console.ReadLine();
            switch (client)
            {
                case "C":
                    Console.WriteLine("Вы зашли как клиент");













                    break;
                case "A":
                    Console.WriteLine("Вы зашли как админ");
                    break;
            }
            

            Console.Write("Введите сумму: ");
            int allMoney = int.Parse(Console.ReadLine());
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
                            double sumMoney = 0.5 * amountOfProduct;
                            if (sumMoney <= allMoney)
                            {

                                Console.WriteLine($"Ваша выбор:Молоко.Сумма покупки:0,50$.Потвердить покупку?(Y/N)");
                                string approveProduct = Console.ReadLine();
                                switch (approveProduct)
                                {
                                    case "Y":
                                        Console.WriteLine("Вы подтвердили покупку");
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
                            double sumMoney = 2.0 * amountOfProduct;
                            if (sumMoney <= allMoney)
                            {
                                Console.WriteLine($"Ваша выбор:Хлеб.Сумма покупки:2,00$.Потвердить покупку?(Y/N)");
                                string approveProduct = Console.ReadLine();
                                switch (approveProduct)
                                {
                                    case "Y":
                                        Console.WriteLine("Вы подтвердили покупку");
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
                            double sumMoney = 1.0 * amountOfProduct;
                            if (sumMoney <= allMoney)
                            {
                                Console.WriteLine($"Ваша выбор:Вишнёвый сок.Сумма покупки:1,00$.Потвердить покупку?(Y/N)");
                                string approveProduct = Console.ReadLine();
                                switch (approveProduct)
                                {
                                    case "Y":
                                        Console.WriteLine("Вы потврердили покупку");
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
                            double sumMoney = 6.0 * amountOfProduct;
                            if (sumMoney <= allMoney)
                            {
                                Console.WriteLine($"Ваша выбор:Плавленный сыр.Сумма покупки:6,00$.Потвердить покупку?(Y/N)");
                                string approveProduct = Console.ReadLine();
                                switch (approveProduct)
                                {
                                    case "Y":
                                        Console.WriteLine("Вы подтвердили покупку");
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

}
