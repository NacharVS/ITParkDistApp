using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct (List<Product> productsParam, string newName, double newPrice, double newCount)
        { 
            productsParam.Add(new Product(newName, newPrice, newCount));
        }

        public static void RemoveProduct(List<Product>products, int numberList)
        {
            products.RemoveAt(numberList - 1);
        }
    }
}
