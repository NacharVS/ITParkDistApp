using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mylib
{
    class Product
    {
        public string name;
        public double price;
        double cost;
        public double quantity = 0;
        public double quantityInStock;

        public Product(string name, double price, double quantityInStock)
        {
            this.name = name;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public Product(Product product, double quantity)
        {
            this.name = product.name;
            this.price = product.price;
            this.quantity = quantity;
            this.cost = this.quantity * this.price;
        }

        public void ChangeQuantity(double quantity)
        {
            this.quantity += quantity;
            this.cost = this.quantity * this.price;
        }

        public bool QuantityCheck(double quantity)
        {
            if (quantityInStock > quantity)
            {
                return true;
            }
            else return false;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}\t{price}\t{quantityInStock}");
        }

        public void PrintCart()
        {
            Console.WriteLine($"{name}\t{price}\t{quantity}\t{cost}");
        }

        public double Cost
        {
            get
            {
                return cost;
            }
        }


    }
}
