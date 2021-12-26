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
                Console.WriteLine("To low quantity of product in the warehouse");
            else
            {
                if(cart.Exists(x => x.productName == productsList[numberInList - 1].productName))
                {
                    if (productsList[numberInList - 1].countOfProduct > count)
                    {
                        cart[cart.FindIndex(x => x.productName == productsList[numberInList - 1].productName)].countOfProduct += count;
                    }
                    else
                        Console.WriteLine("To low quantity of product in the warehouse");
                }
                else
                {
                    productsList[numberInList - 1].countOfProduct -= count;
                    cart.Add(new Product(productsList[numberInList - 1].productName, productsList[numberInList - 1].price, count));
                }
                
            }
            
        }

        public static void AddToCartOrigin(List<Product> productsList, int numberInList, double count)
        {
            if (productsList[numberInList - 1].countOfProduct < count)
                Console.WriteLine("To low quantity of product in the warehouse");
            else
            {
                if(cart.Count == 0)
                {
                    cart.Add(new Product(productsList[numberInList].productName, productsList[numberInList].price));
                    productsList[numberInList].countOfProduct -= count;
                }
                else

                    for (int i = 0; i <= cart.Count-1; i++)
                    {
                        if (cart[i].productName == productsList[numberInList - 1].productName)
                        {
                            cart[i].countOfProduct += count;
                            productsList[numberInList-1].countOfProduct -= count;
                        }
                        else
                        {
                            cart.Add(new Product(productsList[numberInList - 1].productName, productsList[numberInList - 1].price * count));
                            productsList[numberInList - 1].countOfProduct -= count;
                        }

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

        public static double UseCoupon()
        {
            double cost = SolveCost();
            double discountCost = cost * 0.9;
            return discountCost;
            // снижает общую стоимость на 10%
        }

    }


}

