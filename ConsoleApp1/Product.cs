using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string name_product;
        public double prices;
        public int coli_product;

        public Product(string name_product_param, double prices_param, int coli_product_param)
        {
            name_product = name_product_param;
            prices = prices_param;
            coli_product = coli_product_param;
        }

        public static void Spisok_Product(List<Product> products)
        {
            //int n = 1;
            for (int i = 1; i < products.Count; i++)
            {
                Console.WriteLine($"{i}. Product: {products[i]} - price: {products[i]}");
            }
        }

    }
}
