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

        public static void AddToCart(List<Product> productsList, int numberInList, double count)
        {
            if(productsList[numberInList-1].countOfProduct < count)
                Console.WriteLine("Not anough");
            else
            {
                if(cart.Exists(x => x.productName == productsList[numberInList - 1].productName))
                {
                    if (productsList[numberInList - 1].countOfProduct > count)
                    {
                        cart[numberInList - 1].countOfProduct += count;
                    }
                    else
                        Console.WriteLine("Not anough");
                }
                else
                //productsList[numberInList - 1].countOfProduct -= count;
                cart.Add(new Product(productsList[numberInList - 1].productName, productsList[numberInList - 1].price, count));
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

        public static void UseCoupon()
        {
            // снижает общую стоимость на 10%
        }

    }


}

