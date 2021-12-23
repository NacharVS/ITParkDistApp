using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> products, string newName, double newPrice, double newCount)
        {
            products.Add(new Product(newName, newPrice, newCount));
        }

    }
}
