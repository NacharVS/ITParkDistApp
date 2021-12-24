using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Admin
    {
        public static void AddProduct(List<Product> products, string newName, double newPrice, double newCount)
        {
            products.Add(new Product(newName, newPrice, newCount));
        }

        public static void RemoveProduct(List<Product> products, int numberInList)
        {
            products.RemoveAt(numberInList - 1);
        }


    }
}
