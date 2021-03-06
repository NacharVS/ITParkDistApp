using ConsoleApp1.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product : Interface2
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

        public int MyProperty2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void ShowListofProducts(List<Product> productsParam)
        {
            int n = 1;
            foreach (var item in productsParam)
            {
                Console.WriteLine($"{n}. product: {item.productName} - price: {item.price}");
                n++;
            }
        }
    }
}
