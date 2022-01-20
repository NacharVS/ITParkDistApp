using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string ProductName;
        public double Price;
        public double Count;

        public Product(string Productname, double price, double count)
        {
            ProductName = Productname;
            Price = price;
            Count = count;

        }

        public static void SwowListOfProduct(List<Product> productsParam)
        {
            int n = 1;
            foreach (var item in productsParam)
            {
                Console.WriteLine($"{n}.Product {item.ProductName}. Price: {item.Price} Count: {item.Count} ");
                n++;
            }
        }
    }
}
