using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        public static List<Product> Cart = new List<Product>();

        public static void AddToCart(List<Product> productsList, int numberInList, int count)
        {


            if (productsList[numberInList - 1].Count < count)
            {
                Console.WriteLine("Not anough");
            }
            else
            {
                if (Cart.Exists(x => x.ProductName == productsList[numberInList - 1].ProductName))
                {
                    if (productsList[numberInList - 1].Count > count)
                    {
                        Cart[Cart.FindIndex(x => x.ProductName == productsList[numberInList - 1].ProductName)].Count += count;
                    }
                    else
                    {
                        Console.WriteLine("Not anough");
                    }
                }
                else
                {
                    productsList[numberInList - 1].Count -= count;
                    Cart.Add(new Product(productsList[numberInList - 1].ProductName, productsList[numberInList - 1].Price, count));
                }
            }
        }

        public static double Summ()
        {
            double cost = 0;
            foreach (var item in Cart)
            {
                cost += item.Count * item.Price;

            }
            return cost;
        }


        public static void ShowCart()
        {
            foreach (var item in Cart)
            {
                Console.WriteLine($"{item.ProductName} {item.Count}");
            }
        }

    }
}
