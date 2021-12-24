using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mylib
{
    class Customer
    {
        public List<Product> cartList = new List<Product>();
        public List<Product> buyList = new List<Product>();
        
        double cartAmount = 0;
        double money = 0;

        public void AddNewProduct(List<Product> productList, int number, double quantity)
        {
            if (productList[number - 1].QuantityCheck(quantity))
            {
                for (int i = 0; i < cartList.Count; i++)
                {
                    if (cartList[i].NameCheck(cartList[i], productList[number - 1]))
                    {
                        cartList[i].quantity += quantity;

                    }
                    else
                    {
                        cartList.Add(new Product(productList[number - 1], quantity));
                    }
                    cartAmount += cartList[i].Cost;
                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Not enough products in stock!");
            }
        }


        public void RemoveProduct(int index)
        {
            if (index < cartList.Count())
            {
                cartList.RemoveAt(index - 1);
                cartAmount -= cartList[index - 1].Cost;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered the wrong number!");
            }
        }

        public void PrintCartList()
        {
            Console.WriteLine();
            for (int i = 0; i < cartList.Count; i++)
            {
                Console.Write($"{i + 1}\t");
                cartList[i].PrintCart();
            }
            Console.WriteLine($"Total: {cartAmount}");
        }

        public void SetMoney(double money)
        {
            this.money = money;
        }

        public double CartAmount
        {
            get
            {
                return cartAmount;
            }
            set
            {
                cartAmount = value;
            }
        }

        public double Money
        {
            get
            {
                return money;   
            }
            set
            {
                money = value;
            }
        }

        public void Buying()
        {
            Console.WriteLine();
            Console.WriteLine("You bought the following products.");
            PrintCartList();
            Console.WriteLine();
            Console.WriteLine($"Your change: {money - cartAmount}.");
        }

    }
}
