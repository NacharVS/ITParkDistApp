using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {

            
                        List<Product> products = new List<Product>();
                        Admin.AddProduct(products,"bread",20,10);
                        Admin.AddProduct(products, "milk", 20, 5);

                        Product.ShowListofProducts(products);


                        Client.AddToCart(products, 1, 2);
                        Client.AddToCart(products, 2, 1);
                        Client.AddToCart(products, 1, 3);
                        Client.AddToCart(products, 1, 1);
                        Console.WriteLine();

                        Console.WriteLine(Client.SolveCost());
                        Console.WriteLine();
                        Client.ShowCart();
                        Console.WriteLine();
                        Console.WriteLine(Client.UseCoupon());
           




        }
    }

}
  

   
    

