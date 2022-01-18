using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> products, string new_Name, double new_Price, int newColi_Product)
        {
            products.Add(new Product(new_Name, new_Price, newColi_Product));
        }
        
        public static void DeliteProduct(List<Product> products, int numberInlist)
        {
            products.RemoveAt(numberInlist - 1);
        }


    }
}
