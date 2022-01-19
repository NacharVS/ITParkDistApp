using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> productsParam, string NewName, double NewPrice, int newColi_Product)
        {
            productsParam.Add(new Product(NewName, NewPrice, newColi_Product));
        }
        
        public static void DeliteProduct(List<Product> productsParam, int numberInlist)
        {
            productsParam.RemoveAt(numberInlist - 1);
        }


    }
}
