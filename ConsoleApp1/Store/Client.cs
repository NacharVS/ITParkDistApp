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
            if (productsList[numberInList - 1].countOfProduct < count)
            {
                Console.WriteLine("Not enough");
                Console.WriteLine("To low quantity of product in the warehouse");
            }
                
            else
            {
                if (cart.Exists(x => x.productName == productsList[numberInList - 1].productName))
                {
                    if (productsList[numberInList - 1].countOfProduct > count)
                    {
                        //cart[numberInList - 1].countOfProduct += count;
                        productsList[numberInList - 1].countOfProduct -= count;
                        cart[cart.FindIndex(x => x.productName == productsList[numberInList - 1].productName)].countOfProduct += count;
                    }
                    else
                    {
                        Console.WriteLine("Not enough");
                        Console.WriteLine("To low quantity of product in the warehouse");
                    }
                        
                }
                else
                {
                    productsList[numberInList - 1].countOfProduct -= count;
                    cart.Add(new Product(productsList[numberInList - 1].productName, productsList[numberInList - 1].price, count));
                }

            }

        }


        public static void ShowCart()
        {
            int n = 0;
            foreach (var item in cart)
            {
                n++;
                Console.WriteLine($"{n} - {item.productName} - {item.countOfProduct} - {item.countOfProduct * item.price}");
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
        public static double UseCoupon()  // снижает общую стоимость на 10%
        {
            double bonus = 0;
            foreach (var item in cart)
            {
                bonus += item.countOfProduct * item.price * 0.1;
            }
            return bonus;

        }

        public static void RemoveCart(List<Product> productsList, int numberInList, double count)
        {
            if (numberInList > 0 & numberInList <= productsList.Count)
            {
                if (productsList[numberInList - 1].countOfProduct <= count)
                {
                    productsList.RemoveAt(numberInList - 1);
                }
                else
                {
                    productsList[numberInList - 1].countOfProduct -= count;
                }
            }
            else Console.WriteLine("incorrect input"); 
            
        }

    }
}
