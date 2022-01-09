using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Store
{
    class StoreWorks
    {
        public static void StoreWork()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Bread", 42, 20));
            products.Add(new Product("Butter", 120, 10));
            products.Add(new Product("Yoghurt", 36, 100));
            products.Add(new Product("Milk", 47, 30));
            products.Add(new Product("Coffee", 300, 50));

            Product.ShowListofProducts(products);

            Console.WriteLine();
            Console.WriteLine("Are you an admin or a customer? (A/C)");
            string person = Console.ReadLine();
            person = person.ToLower();
            switch (person)
            {
                case "a":
                    Console.WriteLine("Do you want to add a product? (Y/ N)");
                    string toAdd = Console.ReadLine();
                    toAdd = toAdd.ToLower();
                    switch (toAdd)
                    {
                        case ("y"):
                            {
                                Console.WriteLine("Enter product");
                                string productName = Console.ReadLine();
                                Console.WriteLine("Enter price");
                                double productPrice = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter count of product");
                                double productCount = double.Parse(Console.ReadLine());
                                products.Add(new Product(productName, productPrice, productCount));

                                break;
                            }
                        case ("n"): break;
                        default:

                            Console.WriteLine("incorrect input");
                            break;

                    }
                    Console.WriteLine("Do you want to remove a product? (Y/ N)");
                    string toRemove = Console.ReadLine();
                    toRemove = toRemove.ToLower();
                    switch (toRemove)
                    {
                        case ("y"):
                            {
                                Console.WriteLine("Enter number of product you want to remove");
                                int productRemove = int.Parse(Console.ReadLine());
                                Admin.RemoveProduct(products, productRemove);
                                break;
                            }

                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to do anything else? (Y/ N)");
                    string toContinue = Console.ReadLine();
                    toContinue = toContinue.ToLower();
                    if (toContinue == "y") goto case "a";

                    goto case "c";

                case "c":
                    Console.WriteLine("Please enter the sum you want to spend");
                    double sum = double.Parse(Console.ReadLine());
                    Product.ShowListofProducts(products);
                    string buying = "y";

                    //while (Client.SolveCost() <= sum)
                    while (buying == "y")
                    {
                        Console.WriteLine("Enter the number of product you want to buy");
                        int productNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("How much you want to buy?");
                        double productQuantity = double.Parse(Console.ReadLine());

                        if (Client.SolveCost() + products[productNumber - 1].price * productQuantity <= sum)
                        { Client.AddToCart(products, productNumber, productQuantity); }
                        else Console.WriteLine("You are running out of money");


                        Console.WriteLine($"the sum you have spent - {Client.SolveCost() }, the change is {sum - Client.SolveCost() }");
                        Console.WriteLine("the bill of sale:");
                        Client.ShowCart();

                        Console.WriteLine("Do you want to give back any product? (Y/N)");//return some products
                        string giveBack = Console.ReadLine();
                        giveBack = giveBack.ToLower();
                        if (giveBack == "y")
                        {
                            Console.WriteLine("Enter the number of product you want to give back");
                            int giveBackNumber = int.Parse(Console.ReadLine());

                            Console.WriteLine("How much you want to return?");
                            double giveBackQuantity = double.Parse(Console.ReadLine());
                            Client.RemoveCart(Client.cart, giveBackNumber, giveBackQuantity);
                            Client.ShowCart();
                        }


                        Console.WriteLine("Do you want to buy anything else? (Y/N)");
                        buying = Console.ReadLine();
                        buying = buying.ToLower();
                        //if (buying == "n") break;
                    }

                    Console.WriteLine("Have you a bonus coupon? (Y/N)");//use coupon
                    string coupon = Console.ReadLine();
                    coupon = coupon.ToLower();
                    double bonus = 0;
                    if (coupon == "y") bonus = Client.UseCoupon();
                    sum = sum + bonus;
                    Console.WriteLine();
                    Console.WriteLine("the bill of sale:");
                    Client.ShowCart();
                    Console.WriteLine($"the sum you have spent - {Client.SolveCost() - bonus}, the change is {sum - Client.SolveCost()}");
                    Console.WriteLine($"your bonus is {bonus}");

                    break;

                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
        }

    }
}
