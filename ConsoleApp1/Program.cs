using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() { "Bread", "Milk" };
            List<double> prices = new List<double>() { 50, 50 };

            List<double> cart = new List<double>() { 50, 50 };
            Console.WriteLine("Client/Admin");
            string s = Console.ReadLine();
            if (s == "c")
            {
                Console.WriteLine("Enter urmoney");
                double money = 2000;
                while (true)
                {
                    Console.WriteLine("Our list:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]}");
                    }
                    Console.Write("make Ur choice(1, 2, 3...):");
                    string clientsChoice = Console.ReadLine();
                    switch (clientsChoice)
                    {
                        case "1":
                            {
                                Console.Write("Enter count of Bread:");
                                int countOfProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[0] * countOfProduct);
                            }
                            break;
                    }
                    Console.WriteLine("something else?(Y/N)");
                    clientsChoice = Console.ReadLine();
                    if (clientsChoice== "N")
                    {
                        break;
                    }
                }
                double summ = 0;
                for (int i = 0; i < cart.Count; i++)
                {
                    summ += cart[i];
                }
                Console.WriteLine(summ);

            }
            else
            {
                Console.WriteLine("admin");
            }


            //Console.WriteLine("Our list:");
            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine($"{i+1}. {products[i]} {prices[i]}");
            //}
            //double money = 2000;







        }

    }
}
