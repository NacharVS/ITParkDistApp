using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Для_обучения
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> products = new List<string>() { "bread", "Vodka", "Seledka", "seeds", "Tea" };
            List<double> prices = new List<double>() { 100, 450, 250, 50, 190 };
            List<string> currency_name = new List<string>() { "р", "р", "р", "р", "р" };

            List<double> shopping_basket = new List<double>() { };

            Console.WriteLine();
            Console.Write("Client / Admin:  ");
            string s = Console.ReadLine();

            if (s == "Client")
            {
                Console.Write("Enter the amount: ");
                double credit = double.Parse(Console.ReadLine());

                while (true)
                {

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
                                Console.WriteLine("Enter coli.bread");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[0] * coli_product > credit)
                                {
                                    Console.WriteLine("Error limit");
                                }
                                shopping_basket.Add(prices[0] * coli_product);
                            }
                            break;

                        case "2":
                            {
                                Console.WriteLine("Enter coli. Vodka");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[1] * coli_product > credit)
                                {
                                    Console.WriteLine("Error limit");
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
                                    Console.WriteLine("Error limit");
                                }
                                shopping_basket.Add(prices[2] * coli_product);
                            }
                            break;

                        case "4":
                            {
                                Console.WriteLine("Enter coli. seeds");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[3] * coli_product > credit)
                                {
                                    Console.WriteLine("Error limit");
                                }
                                shopping_basket.Add(prices[3] * coli_product);
                            }
                            break;

                        case "5":
                            {
                                Console.WriteLine("Enter coli. Tea");
                                int coli_product = int.Parse(Console.ReadLine());
                                if (prices[4] * coli_product > credit)
                                {
                                    Console.WriteLine("Error limit");
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
                double summ = 0;
                for (int i = 0; i < shopping_basket.Count; i++)
                {
                    summ += shopping_basket[i];
                }
                Console.WriteLine();

                if (summ > credit)
                {
                    Console.WriteLine("Error limit");
                }

                else
                {
                    Console.WriteLine($"Total: {summ}");
                }

            }



            if (s == "Admin")
            {

                Console.WriteLine("Spicok");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]} р");
                }
                Console.Write("Add and Remove (+/-): ");
                string edit = Console.ReadLine();
                switch (edit)
                {
                    case "+":
                        {
                            string add = "+";
                            while (add != "-")
                            {
                                Console.Write("Name of the added position?: ");

                                string newProduct = Console.ReadLine();

                                products.Add(newProduct);
                                Console.Write($"price in Руб per kg. '{newProduct}': ");

                                double coastNewProduct = double.Parse(Console.ReadLine());
                                prices.Add(coastNewProduct);

                                Console.Write("Continue adding?(y/n): ");
                                add = Console.ReadLine();
                                if (add == "n")
                                {
                                    Console.WriteLine("Changed product list:");
                                    for (int i = 0; i < products.Count; i++)
                                    {
                                        Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]} р");
                                    }
                                    break;
                                }
                                else if (add == "y") continue;
                                else Console.WriteLine("Input error: only 'y' and 'n'");
                            }
                        }
                        break;
                    case "-":
                        {
                            string exit = "+";
                            while (exit != "-")
                            {
                                Console.Write("Remove position(№): ");
                                int delProductNumber = int.Parse(Console.ReadLine());

                                string delProduct = products[delProductNumber - 1];

                                int indexRemove = products.IndexOf(delProduct);
                                products.Remove(delProduct);

                                prices.Remove(indexRemove);
                                Console.Write("Continue remove?(y/n): ");

                                exit = Console.ReadLine();
                                if (exit == "n")
                                {
                                    Console.WriteLine("Changed product list:");
                                    for (int i = 0; i < products.Count; i++)
                                    {
                                        Console.WriteLine($" {i + 1}.{products[i]} - {prices[i]} р");
                                    }
                                    break;
                                }
                                else Console.Write(" Input error: only  'y' and 'n'");
                            }
                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Input Error: only  'Client' and 'Admin'");
            }


        }
    }
}
