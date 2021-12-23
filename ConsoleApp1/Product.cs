﻿using System;
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
        public string currentShop;

        public Product(string productName, double price, double countOfProduct)
        {
            this.productName = productName;
            this.price = price;
            this.countOfProduct = countOfProduct;
            currentShop = "Albatros";
        }

        public Product(string productName, double price, double countOfProduct, string shop)
        {
            this.productName = productName;
            this.price = price;
            this.countOfProduct = countOfProduct;
            currentShop = shop;
        }

        public static void ShowListofProducts(List<Product> products)
        {
            int n = 1;
            foreach (var item in products)
            {
                Console.WriteLine($"{n}. product: {item.productName} - price: {item.price}");
                n++;
            }
        }
    }
}