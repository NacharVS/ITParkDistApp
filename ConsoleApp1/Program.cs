using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Bread", 42, 20));
            products.Add(new Product("Butter", 120, 23));
            products.Add(new Product("Yoghurt", 36, 100));
            products.Add(new Product("Milk", 47, 30));
            products.Add(new Product("Coffee", 300, 50));

            Product.ShowListofProducts(products);

            Client.AddToCart(products, 2, 2);
            Client.AddToCart(products, 2, 1);
            Client.AddToCart(products, 3, 2);
            Client.AddToCart(products, 3, 1);
            Client.AddToCart(products, 3, 1);
            Client.AddToCart(products, 5, 1);
            Client.AddToCart(products, 5, 2);
            Client.AddToCart(products, 4, 1);
            Client.AddToCart(products, 1, 4);

            Client.ShowCart();

            Console.WriteLine(Client.SolveCost());

            Console.WriteLine("Применить купон?  (y/n)");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine($"Итоговая стоимость - {Client.UseCoupon()}");
            }
            else
            {
                Console.WriteLine($"Итоговая стоимость - {Client.SolveCost()}");
            }
        }
 


    }
}

