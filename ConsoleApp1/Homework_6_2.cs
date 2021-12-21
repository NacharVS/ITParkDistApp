using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Mylib;

namespace ConsoleApp1
{
    class Homework_6_2
    {
        static void Homework6_2()
            {
                List<Grocery> groceryList = new List<Grocery>();
                List<int> priceList = new List<int>();

                List<string> klientProductList = new List<string>();
                List<int> klientQuantityList = new List<int>();
                List<int> klientSumList = new List<int>();

                bool terminalOperation = true;
                bool adminChangeList = false;
                bool klientChoiceProduct = false;
                bool productBasket = false;

                int summ = 0;
                int klientMoney = 0;

            //List of products
                Grocery.GetGroceryList(groceryList);
            
                //Terminal cycle
                while (terminalOperation)
                {
                    Console.WriteLine();
                    Console.WriteLine("Admin or Klient? (A/K)");
                    string adminOrClient = Console.ReadLine().ToLower();

                switch (adminOrClient)
                {
                    case "a":
                        adminChangeList = true;
                        break;

                    case "k":
                        klientChoiceProduct = true;
                        Console.WriteLine();
                        Console.WriteLine("Enter your account balance:");
                        klientMoney = int.Parse(Console.ReadLine());
                        summ = 0;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You entered the wrong answer!");
                        break;
                }

                    //Administrator work cycle
                    while (adminChangeList)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Do You want to change the list of products? (Y/N)");
                        string answerToChange = Console.ReadLine().ToLower();

                        switch (answerToChange)
                        {
                            //Change the list of products
                            case "y":
                                Console.WriteLine();
                                Console.WriteLine("Do you want to add/remove grocery? (A/R");
                                string answerToAddOrRemove = Console.ReadLine().ToLower();

                            switch (answerToAddOrRemove)
                            {
                                //Add a new product
                                case "a":
                                    Grocery.PrintGroceryList(groceryList);

                                    int newGroceryID = groceryList.Count + 1;

                                    Console.WriteLine();
                                    Console.WriteLine("Write the name of the product:");
                                    string newName = Char.ToUpper(Console.ReadLine()[0]) + Console.ReadLine().Substring(1);

                                    Console.WriteLine();
                                    Console.WriteLine("Enter a new product price:");
                                    int newPrice = int.Parse(Console.ReadLine());

                                    Console.WriteLine();
                                    Console.WriteLine("Enter a new product quantity:");
                                    int newQuantityInStock = int.Parse(Console.ReadLine());

                                    
                                    
                                    if (Grocery.CheckNewGrocery(groceryList, ref newName))
                                    {
                                        Console.WriteLine("This product is already on the list!");

                                        Grocery.PrintGroceryList(groceryList);
                                    }

                                    else
                                    {
                                        groceryList.Add(Grocery.GroceryFormation(newGroceryID, newName, newPrice, newQuantityInStock));

                                        Grocery.PrintGroceryList(groceryList);
                                    }




                                    break;

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

                                default:
                                    Console.WriteLine("You entered the wrong answer!");
                                    break;
                            }

                            break;

                        case "n":
                            adminChangeList = false;
                            break;

                        default:
                            Console.WriteLine();    
                            Console.WriteLine("You entered the wrong answer!");
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


