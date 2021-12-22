using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() { "Bread", "Milk", "Butter", "Eggs", "Meat", "Juice", "Gum" };
            List<double> prices = new List<double>() { 40, 50, 120, 80, 350, 95, 25 };

            List<double> cart = new List<double>() { 0 };
            Console.WriteLine("Enter <C> to login as client");
            Console.WriteLine("Enter <A> to login as admin");
            string s = Console.ReadLine();
            if (s == "C")
            {
                Console.WriteLine("Enter how much money you have");
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
                                Console.Write("Enter count of Butter:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[2] * countOfProduct);
                            }
                            break;
                        case "4":
                            {
                                Console.Write("Enter count of Eggs:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[3] * countOfProduct);
                            }
                            break;
                        case "5":
                            {
                                Console.Write("Enter count of Meat:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[4] * countOfProduct);
                            }
                            break;
                        case "6":
                            {
                                Console.Write("Enter count of Juice:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[5] * countOfProduct);
                            }
                            break;
                        case "7":
                            {
                                Console.Write("Enter count of Gum:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[6] * countOfProduct);
                            }
                            break;
                    }
                    Console.WriteLine("something else?(Y/N)");
                    clientsChoice = Console.ReadLine();
                    if (clientsChoice == "N")
                    {
                        break;
                    }
                }
                double summ = 0;
                for (int i = 0; i < cart.Count; i++)
                {
                    summ += cart[i];
                }
                {
                    Console.WriteLine($"Amount: {summ}");
                    if (summ <= money)
                        summ = money - summ;
                    Console.WriteLine($"Your balance: {summ}");
                }

            }
            else
            if (s == "A")
            {
                Console.WriteLine("Admin");
                Console.WriteLine("Products list:");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]}");
                }
                Console.Write("Add or Delete?(+/-): ");
                string editMode = Console.ReadLine();
                switch (editMode)
                {
                    case "+":
                        {
                            string exit = "Y";
                            while (exit != "N")
                            {

                                Console.Write("The Products name: ");
                                string newProduct = Console.ReadLine();
                                products.Add(newProduct);
                                Console.Write($"Price '{newProduct}': ");
                                double AddNewProduct = double.Parse(Console.ReadLine());
                                prices.Add(AddNewProduct);
                                Console.Write("Сontinue adding?(Y/N): ");
                                exit = Console.ReadLine();
                                if (exit == "N")
                                {
                                    Console.WriteLine("New Products list:");
                                    for (int i = 0; i < products.Count; i++)
                                    {
                                        Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]}");
                                    }
                                    break;
                                }
                                else
                                if (exit == "Y") continue;
                                else Console.WriteLine("Incorrect input");
                            }
                        }
                        break;
                    case "-":
                        {
                            string exit = "Y";
                            while (exit != "N")
                            {
                                Console.Write("What to delete?: ");
                                int delProductNumber = int.Parse(Console.ReadLine());
                                string delProduct = products[delProductNumber - 1];
                                int indexRemove = products.IndexOf(delProduct);
                                products.Remove(delProduct);
                                prices.Remove(indexRemove);
                                Console.Write("Continue to delete?(Y/N): ");
                                exit = Console.ReadLine();
                                if (exit == "N")
                                {
                                    Console.WriteLine("New products list :");
                                    for (int i = 0; i < products.Count; i++)
                                    {
                                        Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]}");
                                    }
                                    break;
                                }
                                else
                                if (exit == "Y") continue;
                                else Console.Write("Incorrect input");
                            }
                        }
                        break;
                }
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}
