using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        public static void AddProduct(List<Product> productsParam, string NewName, double NewPrice, double NewCount)
        {
            productsParam.Add(new Product(NewName, NewPrice, NewCount));

        }

        public static void RemoveProduct(List<Product> productsParam, int numberInList)
        {
            productsParam.RemoveAt(numberInList - 1);
        }
    }
}
