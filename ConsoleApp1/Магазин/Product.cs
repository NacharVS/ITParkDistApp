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
        public int Count;

        public Product(string name_product_param, double prices_param, int coli_product_param)
        {
            ProductName = name_product_param;
            Price = prices_param;
            Count = coli_product_param;
        }

        public static void Spisok_Product(List<Product> products)
        {
           
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}. Product: {products[i].ProductName} - price: {products[i].Price}");
            }
        }

    }
}
