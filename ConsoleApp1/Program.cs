using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our store!");
            List<string> products = new List<string>() {"Apples", "Yogurt", "Tomatoes", "Cucumbers", "Loaf" };
            List<double> prices = new List<double>() {100, 50, 150, 100, 50};
            List<double> cart = new List<double>() { 100, 50, 150, 100, 50 };
            Console.WriteLine("log in as an administrator or as a customer? 0/1 ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Greetings, client.");
                Console.Write("Enter the number of currency units: ");
                double limit = double.Parse(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Our list: ");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                    }
                    Console.Write("Make Ur choice (1, 2, 3...): ");
                    string clientsChoice = Console.ReadLine();
                    switch (clientsChoice)
                    {

                        case "1":
                            {
                                Console.Write("Enter count of Apples:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[0] * countOfProduct);
                                
                            }
                            break;
                        case "2":
                            {
                                Console.Write("Enter count of Yogurt:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[1] * countOfProduct);
                            }
                            break;
                        case "3":
                            {
                                Console.Write("Enter count of Tomatoes:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[2] * countOfProduct);
                            }
                            break;
                        case "4":
                            {
                                Console.Write("Enter count of Cucumbers:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[3] * countOfProduct);
                            }
                            break;
                        case "5":
                            {
                                Console.Write("Enter count of Loaf:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[4] * countOfProduct);
                            }
                            break;
                           
                     }
           Console.WriteLine("Something else?(Y/N)");
           clientsChoice = Console.ReadLine();
           clientsChoice = clientsChoice.ToLower();
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
                Console.WriteLine(summ);
                if (limit< summ)
                    Console.WriteLine("You don't have enough funds!");
                else
                {
                   double change= limit - summ;
                    Console.WriteLine($"You change: {change}");
                }

            }
            else
            {
                Console.WriteLine("Greetings, administrator.");
                while (true)
                {
                    Console.WriteLine("Do you want to add a new torav? or Delete. Add/Delete ");
                    string choice2 = Console.ReadLine();
                    choice2 = choice2.ToLower();
                    switch (choice2)
                    {
                        case "delete":
                            Console.WriteLine("Select the product that you want to remove from the list");
                            products.Remove(Console.ReadLine());
                            Console.WriteLine();
                            break;

                        case "add":

                            Console.WriteLine();
                            Console.Write("Enter a new product: ");
                            products.Add(Console.ReadLine());
                            Console.Write("Enter the cost of the product: ");
                            prices.Add(double.Parse(Console.ReadLine()));
                            Console.WriteLine();
                            break;
                    }
                   
                    Console.WriteLine("Do you want to continue working with the catalog? (Y/N)");
                   string choice3 = Console.ReadLine();
                    choice3 = choice3.ToLower();
                    if (choice3 == "N")
                    {
                        break;
                    }

                }
              
            }

        }
           
            
     }

}
  

   
    

