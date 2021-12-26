using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> productsParam, string newName, double newPrice, double newCount)
        {
            productsParam.Add(new Product(newName, newPrice, newCount));
        }

        public static void RemoveProduct(List<Product> productsParam, int numberInList)
        {
            productsParam.RemoveAt(numberInList-1);
        }

    }
}
