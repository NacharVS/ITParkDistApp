using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = new List<string>();
            List<int> priceList = new List<int>();

            List<string> klientProductList = new List<string>();
            List<int> klientQuantityList = new List<int>();
            List<int> klientSumList = new List<int>();

            int terminalOperation = 1;
            int adminChangeList = 0;
            int klientChoiceProduct = 0;
            int productBasket = 0;

            int summ = 0;
            int klientMoney = 0;

            //List of products
            groceryList.Add("Bread");
            groceryList.Add("Egg");
            groceryList.Add("Milk");
            groceryList.Add("Cheese");
            groceryList.Add("Butter");
            groceryList.Add("Potatoes");
            groceryList.Add("Carrots");
            groceryList.Add("Onions");
            groceryList.Add("Cabbage");

            //List of price
            priceList.Add(26);
            priceList.Add(7);
            priceList.Add(60);
            priceList.Add(450);
            priceList.Add(120);
            priceList.Add(42);
            priceList.Add(35);
            priceList.Add(30);
            priceList.Add(45);



            //Terminal cycle
            while (terminalOperation == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Go to the terminal if as an administrator then select 0 if as a client then 1.");
                int adminOrClient = int.Parse(Console.ReadLine());

                if (adminOrClient == 0) adminChangeList = 1;
                else if (adminOrClient == 1)
                {
                    klientChoiceProduct = 1;
                    Console.WriteLine();
                    Console.WriteLine("Enter your account balance:");
                    klientMoney = int.Parse(Console.ReadLine());
                    summ = 0;
                }
                else Console.WriteLine("You entered the wrong answer.");

                //Administrator work cycle
                while (adminChangeList == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You want to change the list of products? If you want enter 1, not - 0.");
                    int answerToChange = int.Parse(Console.ReadLine());

                    switch (answerToChange)
                    {
                        case 0:
                            adminChangeList = 0;
                            break;

                        //Change the list of products
                        case 1:
                            Console.WriteLine("If you want to add - enter 1, remove - 0");
                            int answerToAddOrRemove = int.Parse(Console.ReadLine());

                            switch (answerToAddOrRemove)
                            {
                                //Remove a product
                                case 0:
                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Enter product number:");
                                    int productNumber = int.Parse(Console.ReadLine()) - 1;
                                    groceryList.RemoveAt(productNumber);
                                    priceList.RemoveAt(productNumber);

                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    break;

                                //Add a new product
                                case 1:
                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Write the name of the product:");
                                    string newProduct = Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Enter a price for a new product:");
                                    int newPrice = int.Parse(Console.ReadLine());


                                    if (groceryList.Contains(newProduct) == false)
                                    {
                                        groceryList.Add(newProduct);
                                        priceList.Add(newPrice);

                                        //groceryList.Sort();

                                        Console.WriteLine();
                                        for (int i = 0; i < groceryList.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                        }
                                    }

                                    else
                                    {
                                        Console.WriteLine("This product is already on the list!");

                                        Console.WriteLine();
                                        for (int i = 0; i < groceryList.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                        }
                                    }

                                    break;

                                default:
                                    Console.WriteLine("You entered the wrong answer.");
                                    break;
                            }

                            break;



                        default:
                            Console.WriteLine("You entered the wrong answer.");
                            break;
                    }

                }

                //Cart selection cycle
                while (klientChoiceProduct == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected products for the amount: {summ}. You have left: {klientMoney - summ}");

                    Console.WriteLine();
                    Console.WriteLine("You want to add/ remove a product to your cart? If you want add enter 1, if remove enter 2, if not - 0.");
                    int addToBasket = int.Parse(Console.ReadLine());

                    int sumProduct;
                    int productNumber;

                    switch (addToBasket)
                    {

                        case 0:
                            klientChoiceProduct = 0;
                            productBasket = 1;
                            break;

                        //Add product
                        case 1:
                            Console.WriteLine();

                            for (int i = 0; i < groceryList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Enter product number:");
                            productNumber = int.Parse(Console.ReadLine()) - 1;

                            Console.WriteLine();
                            Console.WriteLine("Enter quantity:");
                            int productQuantity = int.Parse(Console.ReadLine());

                            sumProduct = productQuantity * priceList[productNumber];

                            summ += sumProduct;

                            klientProductList.Add(groceryList[productNumber]);
                            klientQuantityList.Add(productQuantity);
                            klientSumList.Add(sumProduct);

                            break;
                        //Remove product
                        case 2:
                            Console.WriteLine();

                            for (int i = 0; i < klientProductList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Enter product number:");
                            productNumber = int.Parse(Console.ReadLine()) - 1;

                            summ -= klientSumList[productNumber];

                            klientProductList.RemoveAt(productNumber);
                            klientQuantityList.RemoveAt(productNumber);
                            klientSumList.RemoveAt(productNumber);

                            break;

                        //error
                        default:
                            Console.WriteLine();
                            Console.WriteLine("You entered the wrong answer.");
                            break;
                    }
                }

                while (productBasket == 1)
                {
                    if (klientMoney > summ)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have selected the following products.");
                        Console.WriteLine();

                        for (int i = 0; i < klientProductList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                        }

                        Console.WriteLine($"Total: {summ}");

                        productBasket = 0;

                        Console.WriteLine("Buy? If yes - enter 1, if no - 0.");
                        int buy = int.Parse(Console.ReadLine());

                        switch (buy)
                        {
                            case 0:
                                klientChoiceProduct = 1;
                                break;

                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("You bought the following products.");
                                Console.WriteLine();
                                for (int i = 0; i < klientProductList.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                                }

                                Console.WriteLine($"Total: {summ}");
                                Console.WriteLine();
                                Console.WriteLine($"Your change: {klientMoney - summ}.");

                                terminalOperation = 0;
                                break;


                            //error
                            default:
                                Console.WriteLine();
                                Console.WriteLine("You entered the wrong answer.");
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        productBasket = 0;
                        klientChoiceProduct = 1;
                    }
                }
            }
        }
    }
}
