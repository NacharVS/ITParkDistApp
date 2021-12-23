using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> products, string newName, double newPrice, double newCount)
        {
            products.Add(new Product(newName, newPrice, newCount));
        }

        public static void RemoveProduct(List<Product> products, int numberInList)
        {
            products.RemoveAt(numberInList-1);
        }

    }
}
