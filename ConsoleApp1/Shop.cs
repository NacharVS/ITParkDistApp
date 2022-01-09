using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop
    {
        public static void ShopWork()
        {
            //store
            List<string> products = new List<string>();
            List<double> price = new List<double>();
            List<string> boughtProduct = new List<string>();
            List<double> productCount = new List<double>();
            List<double> productSum = new List<double>();

            products.Add("ryebread");
            price.Add(26);
            products.Add("bread");
            price.Add(32);
            products.Add("milk");
            price.Add(54);
            products.Add("butter");
            price.Add(164);

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i]}  -  {price[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Are you an admin or a customer?");
            string person = Console.ReadLine();
            person = person.ToLower();
            switch (person)
            {
                case "admin":
                    Console.WriteLine("Do you want to add a product? (YES/ NO)");
                    string toAdd = Console.ReadLine();
                    toAdd = toAdd.ToLower();
                    switch (toAdd)
                    {
                        case ("yes"):
                            {
                                Console.WriteLine("Enter product");
                                products.Add(Console.ReadLine());
                                Console.WriteLine("Enter price");
                                price.Add(double.Parse(Console.ReadLine()));

                                break;
                            }
                        case ("no"): break;
                        default:

                            Console.WriteLine("incorrect input");
                            break;

                    }
                    Console.WriteLine("Do you want to remove a product? (YES/ NO)");
                    string toRemove = Console.ReadLine();
                    toRemove = toRemove.ToLower();
                    switch (toRemove)
                    {
                        case ("yes"):
                            {
                                Console.WriteLine("Enter product you want to remove");
                                string productRemove = Console.ReadLine();
                                productRemove = productRemove.ToLower();
                                int indexRemove = -1;
                                foreach (string item in products)
                                {
                                    if (item == productRemove)
                                    {
                                        indexRemove = products.IndexOf(item);
                                    }
                                }
                                if (indexRemove == -1) Console.WriteLine("incorrect input");
                                else
                                {
                                    products.RemoveAt(indexRemove);
                                    price.RemoveAt(indexRemove);
                                }
                                break;
                            }

                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to do anything else? (yes/ no)");
                    string toContinue = Console.ReadLine();
                    toContinue = toContinue.ToLower();
                    if (toContinue == "yes") goto case "admin";

                    goto case "customer";

                case "customer":
                    Console.WriteLine("Please enter the sum you want to spend");
                    double sum = double.Parse(Console.ReadLine());
                    //double productPrice;
                    double productQuantity;
                    double resultSum = 0;
                    int index = -1;

                    while (resultSum <= sum)
                    {
                        Console.WriteLine("Enter the product you want to buy");
                        string choise = Console.ReadLine();
                        choise = choise.ToLower();

                        foreach (string item in products)
                        {
                            if (item == choise)
                            {
                                index = products.IndexOf(item);

                            }
                        }
                        Console.WriteLine("How much you want to buy?");
                        productQuantity = double.Parse(Console.ReadLine());

                        if (index == -1) break;
                        if (productQuantity * price[index] <= (sum - resultSum))
                        {
                            boughtProduct.Add(products[index]);
                            productCount.Add(productQuantity);
                            productSum.Add(productQuantity * price[index]);
                            resultSum = resultSum + price[index] * productQuantity;
                            index = -1;
                        }

                        else Console.WriteLine("You are running out of money");
                        Console.WriteLine($"the sum you have spent - {resultSum}, the change is {sum - resultSum}");
                        Console.WriteLine("Do you want to buy anything else? (YES/NO)");
                        string buying = Console.ReadLine();
                        buying = buying.ToLower();
                        if (buying == "no") break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("the bill of sale:");
                    for (int i = 0; i < boughtProduct.Count; i++)
                    {
                        Console.WriteLine($"{boughtProduct[i]} - {productCount[i]}  -  {productSum[i]}");
                    }
                    Console.WriteLine($"the sum you have spent - {resultSum}, the change is {sum - resultSum}");
                    break;

                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Products in the shop:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i]}  -  {price[i]}");
            }

        }


        //список
        /*
        List<int> list = new List<int>();
        list.Add(5);
        list.Add(44);
        list.Add(256);
        list.Add(89);
        if (list.Contains(5))
            Console.WriteLine(list.IndexOf(5));
        else Console.WriteLine("not founded");
        Console.WriteLine(list.Contains(44));
        */
    }
}
