using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        public static List<Product> cart = new List<Product>();
        public static void AddToCart(List<Product> productsList, int numberinList, double count)
        {
            if (productsList[numberinList - 1].countOfProduct < count)
                Console.WriteLine("Not anough");
            else
            {
                if (cart.Exists(x => x.productName == productsList[numberinList - 1].productName))
                {
                    if (productsList[numberinList - 1].countOfProduct > count)
                    {
                        cart[numberinList - 1].countOfProduct += count;
                    }
                    else
                        Console.WriteLine("To low quantity of product in the warehouse");
                }
                else
                {
                    productsList[numberinList - 1].countOfProduct -= count;
                    cart.Add(new Product(productsList[numberinList - 1].productName, productsList[numberinList - 1].price, count));
                }
                    
            }
        }

        public static void AddToCartOrigin(List<Product> productsList, int numberInList, double count)
        {
            if (productsList[numberInList - 1].countOfProduct < count)
                Console.WriteLine("To low quantity of product in the warehouse");
            else
            {
                if (cart.Count == 0)
                {
                    cart.Add(new Product(productsList[numberInList].productName, productsList[numberInList].price));
                    productsList[numberInList].countOfProduct -= count;
                }
                else
                {
                    cart.Add(new Product(productsList[numberInList - 1].productName, productsList[numberInList - 1].price * count));
                    productsList[numberInList - 1].countOfProduct -= count;
                }
            }  
        }
        public static void ShowCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine($"{item.productName} {item.countOfProduct}");
            }
        }

        public static double SolveCost()
        {
            double cost = 0;
            foreach (var item in cart)
            {
                cost += item.countOfProduct * item.price;
            }
            return cost;
        }
    }
}
