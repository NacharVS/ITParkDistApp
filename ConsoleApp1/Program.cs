using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> products = new List<string>() { "Beer", "Vodka", "Seledka", "Lavash" , "Juice" };
            List<double> prices = new List<double>() { 100, 450, 250, 50, 190 };
            List<string> currency_name = new List<string>() { "Р", "Р", "Р" , "Р" , "Р" };

            List<double> shopping_basket = new List<double>() { 100, 450, 250 };

            Console.WriteLine();
            Console.Write("Client and Admin:  ");
            string s = Console.ReadLine();
           
            if (s == "Client")
            {
                while (true)
                {
                    Console.Write("Your credit limit: ");
                    double credit = double.Parse(Console.ReadLine());

                    Console.WriteLine("Spicok");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]} {currency_name[i]}");

                    }
                    Console.WriteLine("Make your choice(ot 1 do 5)");
                    string client_choise = Console.ReadLine();
                    switch (client_choise)
                    {
                        case "1":
                            {
                                Console.WriteLine("Enter coli. Beer");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[0] * coli_product > credit)
                                {
                                    Console.WriteLine("Error Credit limit");
                                }
                                shopping_basket.Add (prices[0] * coli_product); 
                            }
                            break;

                        case "2":
                            {
                                Console.WriteLine("Enter coli. Vodka");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[1] * coli_product > credit)
                                {
                                    Console.WriteLine("Error Credit limit");
                                }
                                shopping_basket.Add(prices[1] * coli_product);
                            }
                            break;

                        case "3":
                            {
                                Console.WriteLine("Enter coli. Seledka");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[2] * coli_product > credit)
                                {
                                    Console.WriteLine("Error Credit limit");
                                }
                                shopping_basket.Add(prices[2] * coli_product);
                            }
                            break;

                        case "4":
                            {
                                Console.WriteLine("Enter coli. Lavash");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[3] * coli_product > credit)
                                {
                                    Console.WriteLine("Error Credit limit");
                                }
                                shopping_basket.Add(prices[3] * coli_product);
                            }
                            break;

                        case "5":
                            {
                                Console.WriteLine("Enter coli. Juice");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[4] * coli_product > credit)
                                {
                                    Console.WriteLine("Error Credit limit");
                                }
                                shopping_basket.Add(prices[4] * coli_product);
                            }
                            break;
                    }
                    Console.Write("Anything else? (Y/N)");
                    client_choise = Console.ReadLine();
                    if (client_choise == "N")
                    {
                        break;
                    }
                        

                }
                
            }


            else
            {
                if(s == "Admin")
                {
                    Console.WriteLine("Admin");

                }
                else
                {
                    Console.WriteLine("Error entered incorrectly");
                }
            }
            


        }
    }

    

