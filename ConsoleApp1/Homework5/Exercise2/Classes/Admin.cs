using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework5.Exercise2.Classes
{
    class admin
    {

        public static void AddProduct(List<Product> productsParam, string newName, double newPrice, double newCount)
        {          
            productsParam.Add(new Product(newName, newPrice, newCount));
           
        }

        public static void RemoveProduct(List<Product> productsParam, int numberInList)
        {
            productsParam.RemoveAt(numberInList - 1);
        }
    }
}
