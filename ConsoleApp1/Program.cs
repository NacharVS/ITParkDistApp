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
            List<Product> products = new List<Product>();
            products.Add(new Product("Пиво", 100.25, 47));
            products.Add(new Product("Водка", 490.90, 126));
            products.Add(new Product("Селедка", 88.40, 15));
            products.Add(new Product("Лаваш", 30.00, 20));
            products.Add(new Product("Сок", 190.00, 55));

            Console.Write("Client and Admin:  ");

            string s = Console.ReadLine();
            if (s == "Admin")
            {
                Product.Spisok_Product(products);
                Console.WriteLine("ADD/Remove(+/-)");
                string edit = Console.ReadLine();
                switch (edit)
                {
                    case "+":
                        //Добавление нового продукта----------------------------------------------

                        Console.WriteLine("New product name");
                        string NewProductName = Console.ReadLine();

                        Console.WriteLine("New product price");
                        double NewProductPrice = double.Parse(Console.ReadLine());

                        Console.WriteLine("New product count");
                        int NewProductcount = int.Parse(Console.ReadLine());



                        Admin.AddProduct(products, NewProductName, NewProductPrice, NewProductcount);
                        Console.WriteLine("New List");
                        Product.Spisok_Product(products);
                        break;
                    //Удаление продукта---------------------------------------------------------
                    case "-":

                        Console.WriteLine("Remove product №:");
                        int RemoveProduct = int.Parse(Console.ReadLine());

                        Admin.DeliteProduct(products, RemoveProduct);
                        Console.WriteLine("New List");
                        Product.Spisok_Product(products);

                        break;
                }
            }
            if (s == "Client")
            {
                Console.Write("Your credit limit: ");
                double Summa = double.Parse(Console.ReadLine());

                //Выбор продукта-------------------------------------------------------------------------
                Console.WriteLine("Сhoose a product:1 of 5");
                Product.Spisok_Product(products);

                int choiceProduct = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Quantity");
                int countedProduct = int.Parse(Console.ReadLine());
                Client.AddToCart(products, choiceProduct, countedProduct);

                Console.WriteLine("Your choice");


                while (true)
                {
                    Console.WriteLine("Do you want to buy something else?(Y/N)");

                    string still = Console.ReadLine();
                    switch (still)
                    {
                        case "Y":

                            Console.WriteLine("Сhoose a product:1 of 5");
                            Product.Spisok_Product(products);

                            int NextchoiceProduct = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product Quantity");
                            int NextcountedProduct = int.Parse(Console.ReadLine());
                            Client.AddToCart(products, NextchoiceProduct, NextcountedProduct);

                            break;
                    }
                    if (still == "N")
                    {
                        break;
                    }

                }

                Console.WriteLine("Your choice");
                Client.ShowCart();
                Console.WriteLine($"Purchase amount: {Client.Summ()} p.");
                if (Summa < Client.Summ())
                {
                    Console.WriteLine("Not enough money");
                }

            }


        }
    }
}
