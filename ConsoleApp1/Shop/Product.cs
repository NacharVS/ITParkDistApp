using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string productName;
        public double price;
        public double countOfProduct;

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;

        }

        public Product(string productName, double price, double countOfProduct)
        {
            this.productName = productName;
            this.price = price;
            this.countOfProduct = countOfProduct;
        }

        public static void ShowListOfProducts(List<Product> productsParam)
        {
            int n = 1;
            foreach (var item in productsParam)
            {
                Console.WriteLine($"{n}. {item.productName} - {item.price}");
                n++;
            }
        }

    }
}
