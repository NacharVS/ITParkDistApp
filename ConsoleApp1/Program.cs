using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("We greet you!");
            Console.WriteLine("Catalog product: ");

            List<Product> products = new List<Product>();
            products.Add(new Product("Bread", 42, 20));
            products.Add(new Product("Butter", 120, 23));
            products.Add(new Product("Yoghurt", 36, 100));
            products.Add(new Product("Milk", 47, 30));
            products.Add(new Product("Coffee", 300, 50));

            Product.ShowListofProducts(products);
            Console.WriteLine();
            
                Console.WriteLine("Do you want to log in as a client(C) or administrator(A)? A/C, no- exiting the application");
                string choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "c")
                {
                    Console.WriteLine("Greetings, client.");
               
                Console.Write("Enter the number of currency units: ");
                    double limit = double.Parse(Console.ReadLine());
                    while (true)
                    {
                    
                    Console.WriteLine("Enter the number of the selected item: ");
                        int numberInListC = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the quantity of the selected item: ");
                        double count = int.Parse(Console.ReadLine());
                        Client.AddToCart(products, numberInListC, count);
                        Console.WriteLine("Do you want to continue choosing products? (Yes) Or remove some of the products from the list? (Delete) Or pay for the item (s)? (Not)");
                        string choice4 = Console.ReadLine();
                        choice4 = choice4.ToLower();
                    if (choice4 == "delete")
                        Console.WriteLine("Select the product number you want to remove from the list:");
                    int numberInList = int.Parse(Console.ReadLine());
                    Client.RemoveCart(products, numberInList);
                    
                        if (choice4 == "no")
                            break;
                    }

                    Console.WriteLine("Your shopping list: ");
                    Client.ShowCart();
                    Console.WriteLine();
                    Console.WriteLine("Your order amount: ");
                    Console.WriteLine(Client.SolveCost());
                    if (limit < Client.SolveCost())
                    {
                        Console.WriteLine("You don't have enough funds!");
                    }

                    else
                    {
                        Console.WriteLine("Apply coupon (minus 10% of the total order value)?Yes/No");
                        string choice5 = Console.ReadLine();
                        choice5 = choice5.ToLower();
                        if (choice5 == "yes")
                        {
                            Console.WriteLine("The cost of your order, after applying the coupon:");
                            Console.WriteLine(Client.UseCoupon());
                            double change = limit - Client.UseCoupon();
                            Console.WriteLine($"Your change: {change}");
                        }
                    }
                }

                else

                {
                    Console.WriteLine("Do you want to add a new product? or delete? Add/Delete or no");

                    string choice2 = Console.ReadLine();
                    choice2 = choice2.ToLower();
                    while (choice2 == "add" || choice2 == "delete")
                    {
                        switch (choice2)
                        {
                            case "delete":
                                Console.WriteLine();
                                Console.WriteLine("Select the product number you want to remove from the list: ");
                                int numberInList = int.Parse(Console.ReadLine());
                                Admin.RemoveProduct(products, numberInList);
                                Product.ShowListofProducts(products);
                                Console.WriteLine();
                                break;
                            case "add":

                                Console.WriteLine();
                                Console.WriteLine("Enter product name: ");
                                string newName = Console.ReadLine();
                                Console.WriteLine("Enter product product price: ");
                                double newPrice = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product number: ");
                                double newCount = double.Parse(Console.ReadLine());
                                Admin.AddProduct(products, newName, newPrice, newCount);
                                Console.WriteLine("New product added to the list: ");
                                Product.ShowListofProducts(products);
                                Console.WriteLine();
                                break;
                        }
                        Console.WriteLine("Do you want to continue adding products?  Add/Delete or no ");
                        string choice3 = Console.ReadLine();
                        choice2 = choice3.ToLower();
                        if (choice3 == "no")
                            break;

                    }
                }
                


            
         
        }

    }

}
  

   
    

