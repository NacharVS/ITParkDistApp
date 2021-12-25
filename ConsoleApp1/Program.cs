using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Bread", 40, 50));
            products.Add(new Product("Milk", 50, 50));
            products.Add(new Product("Butter", 120, 50));
            products.Add(new Product("Eggs", 80, 50));
            products.Add(new Product("Meat", 350, 50));
            products.Add(new Product("Juice", 95, 50));
            products.Add(new Product("Gum", 25, 50));

            List<double> cart = new List<double>() { 0 };
            Console.WriteLine("Enter <C> to login as client");
            Console.WriteLine("Enter <A> to login as admin");
            string s = Console.ReadLine();
            if (s == "C")
            {
                Console.WriteLine("Enter how much money you have");
                double money = double.Parse(Console.ReadLine());
                Product.ShowListOfProducts(products);
                Console.Write("make Ur choice(1, 2, 3...):");
                while (true)
                {              
                    {
                        string exit = "Y";
                        while (exit != "N")
                        {
                            int clientsChoice = int.Parse(Console.ReadLine());
                            Console.Write("Enter count:");
                            int countOfProduct = int.Parse(Console.ReadLine());
                            Console.WriteLine("something else?(Y/N)");
                            exit = Console.ReadLine();
                            Client.AddToCart(products, clientsChoice, countOfProduct);
                            Client.ShowCart();
                            Console.WriteLine($"Shoping summ: {Client.SolveCost()}");
                            if (exit == "N")
                            {
                                break;
                            }
                        }
                    }
                    if (Client.SolveCost() > money) ;
                    {
                        Console.WriteLine("Not enough!");
                    }
                }    
            }
            else
            if (s == "A")
            {
                Console.WriteLine("Admin");
                Console.WriteLine("Products list:");
                Product.ShowListOfProducts(products);
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
                                Console.Write($"Price '{newProduct}': ");
                                double priceNewProduct = double.Parse(Console.ReadLine());
                                Console.Write($"How much? '{newProduct}': ");
                                double countNewProduct = double.Parse(Console.ReadLine());
                                Admin.AddProduct(products, newProduct, priceNewProduct, countNewProduct);
                                Console.WriteLine("New List:");
                                Product.ShowListOfProducts(products);
                                Console.Write("Сontinue adding?(Y/N): ");
                                exit = Console.ReadLine();
                                if (exit == "Y") continue;
                                if (exit == "N") break;
                                else Console.WriteLine("Incorrect input");
                            }
                            break;   
                        }
                        
                    case "-":
                        {
                            string exit = "Y";
                            while (exit != "N")
                            {
                                Console.Write("What to delete?: ");
                                int delProductNumber = int.Parse(Console.ReadLine());
                                Admin.RemoveProduct(products, delProductNumber);
                                Product.ShowListOfProducts(products);
                                Console.Write("Continue to delete?(Y/N): ");
                                exit = Console.ReadLine();
                                if (exit == "Y") continue;
                                if (exit == "N") break;
                                else Console.WriteLine("Incorrect input");
                            }
                        }
                        break;
                }    
            }
        }
    }
}
