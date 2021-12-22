﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission8
    {
//        1. Реализовать каталог товаров с ценами за 1 единицу/1 кг.Приложение, предлагает войти как администратору или как клиенту.

//1.1 Администратор может добавлять новые товары/удалять старые.Приложение спрашивает хотите продолжить редактирование каталога или нет.Если нет, то возврат к выбору админ/клиент.

//1.2 При авторизации в качестве клиента, предлагается ввести количество денежных единиц.

//Клиент может выбирать товар и выбирать количество товара. после выбора товара и ввода количества товара, клиент может перейти к оплате или продолжить выбор, тем самым формируя список покупок.Формируется список покупок и подсчет общей стоимости.После того, как клиент перешёл к оплате, осуществляется проверка.. Если введенное в начале число денежных единиц недостаточно, тогда появляется соответствующее уведомление.
//Если Достаточно, тогда покупка проходит, и осуществляется подсчет сдачи необходимой к возврату
        public static void Shop()
        {
            List<string> products = new List<string>() { "Bread", "Milk", "Meat", "Tomts", "Eggs" };
            List<double> prices = new List<double>() { 50, 50, 270, 130, 90 };

            List<double> cart = new List<double>() { };
            Console.WriteLine("Client/Admin");
            string s = Console.ReadLine();
            if (s == "c")
            {
                Console.WriteLine("Enter urmoney");
                double money = double.Parse(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Our list:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                    }
                    Console.Write("make Ur choice(1, 2, 3...):");
                    string clientsChoice = Console.ReadLine();
                    switch (clientsChoice)
                    {
                        case "1":
                            {
                                Console.Write("Enter count of Bread:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[0] * countOfProduct);
                            }
                            break;
                        case "2":
                            {
                                Console.Write("Enter count of Milk:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[1] * countOfProduct);
                            }
                            break;
                        case "3":
                            {
                                Console.Write("Enter count of Meat:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[2] * countOfProduct);
                            }
                            break;
                        case "4":
                            {
                                Console.Write("Enter count of Tomats:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[3] * countOfProduct);
                            }
                            break;
                        case "5":
                            {
                                Console.Write("Enter count of Eggs:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[4] * countOfProduct);
                            }
                            break;
                    }
                    Console.WriteLine("something else?(Y/N)");
                    clientsChoice = Console.ReadLine();
                    if (clientsChoice == "n")
                    {
                        break;
                    }
                }
                double summ = 0;
                for (int i = 0; i < cart.Count; i++)
                {
                    summ += cart[i];
                }
                Console.WriteLine(summ);
                if (money < summ)
                {
                    Console.WriteLine("Purchase failed");
                }
                else
                {
                    double change = money - summ;
                    Console.WriteLine(products);
                    Console.WriteLine($"You chenge from purchase = {change}");
                }

            }
            else if (s == "a")
            {
                Console.WriteLine("admin");
                while (true)
                {
                    Console.WriteLine("Add product or delete product? make (a/d)");
                    string adminmake = Console.ReadLine();
                    switch (adminmake)
                    {
                        case "a":
                            {
                                string continuework = "y";
                                while (continuework != "n")
                                {
                                    Console.WriteLine("Name new product");
                                    string addproduct = Console.ReadLine();
                                    products.Add(addproduct);
                                    Console.WriteLine("Cost new product");
                                    double coustnewproduct = double.Parse(Console.ReadLine());
                                    prices.Add(coustnewproduct);
                                    Console.WriteLine("Continue add new products? (y/n)");
                                    continuework = Console.ReadLine();
                                    if (continuework == "n")
                                    {
                                        Console.WriteLine("Our list:");
                                        for (int i = 0; i < products.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                                        }
                                        break;
                                    }
                                    else if (continuework == "y") continue;
                                    break;
                                }
                                break;
                            }
                        case "d":
                            {
                                Console.WriteLine("Our list:");
                                for (int i = 0; i < products.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                                }
                                Console.WriteLine("Wich remove product?");
                                products.Remove(Console.ReadLine());
                                break;
                            }
                    }
                    Console.WriteLine("Want to continue working? (y/n)");
                    adminmake = Console.ReadLine();
                    if (adminmake == "n")
                    {
                        break;
                    }
                }
            }

        }
    }
}
