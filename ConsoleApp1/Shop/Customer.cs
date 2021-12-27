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
        double cartAmountDiscount;
        double money = 0;
        double discount = 0;

        public void AddNewProduct(List<Product> productList, int number, double quantity)
        {
            number -= 1;
            int lenth = cartList.Count;
            bool flag = false;
                        
            if (number <= productList.Count)
            {
                string bufferName = productList[number].name;

                if (productList[number].QuantityCheck(quantity))
                {
                    if (cartList.Count > 0)
                    {
                        for (int i = 0; i < lenth; i++)
                        {
                            if (cartList[i].name == bufferName)
                            {
                                flag = true;
                                cartList[i].ChangeQuantity(quantity);
                            }
                        }

                        if (flag == false)
                        {
                            cartList.Add(new Product(productList[number], quantity));
                        }

                        productList[number].quantityInStock -= quantity;
                    }

                    else
                    {
                        cartList.Add(new Product(productList[number], quantity));
                        productList[number].quantityInStock -= quantity;
                    }
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Not enough products in stock!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered the wrong number!");
            }
            
        }


        public void RemoveProduct(List<Product> productList, int number)
        {
            number -= 1;
            string bufferName = cartList[number].name;

            if ((number) <= cartList.Count())
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    if (bufferName == productList[i].name)
                    {

                        cartAmount -= cartList[number].Cost;
                        productList[i].quantityInStock += cartList[number].quantity;
                        cartList.RemoveAt(number);
                    }
                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered the wrong number!");
            }
        }

        public double SetCartAmount()
        {
            cartAmount = 0;

            foreach (var item in cartList)
            {
                cartAmount += item.Cost;
            }
            return cartAmount;
        }

        public double SetCartAmountDiscount()
        {
            cartAmountDiscount = cartAmount - cartAmount * discount / 100;
            return cartAmountDiscount;
        }



        public void PrintCartList()
        {
            
            Console.WriteLine();
            for (int i = 0; i < cartList.Count; i++)
            {
                Console.Write($"{i + 1}\t");
                cartList[i].PrintCart();
            }

            Console.WriteLine($"==============================================");
            Console.WriteLine($"Total:                          {SetCartAmount()}");
            Console.WriteLine($"Total with a discount: {discount}%      {SetCartAmountDiscount()}");
            Console.WriteLine($"==============================================");


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
            Console.WriteLine("You bought the following products:");
            PrintCartList();
            Console.WriteLine();
            Console.WriteLine($"Your change: {money - cartAmountDiscount}.");
        }

        public void BuyingDiscount()
        {
            discount = 10;
            Buying();
        }

    }
}
