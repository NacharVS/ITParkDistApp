using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача № 1

            List<string> products = new List<string>() { "Сахар-", "Молоко-","Хлеб-"};
            List<double> prices = new List<double>() { 50, 50, 50 };


            List<double> cart= new List<double>() { 50, 50, 50 };
            Console.WriteLine("Client/Admin");

            string s = Console.ReadLine();

            if (s == "c")
            {

                Console.WriteLine("Вы зашли как клиент");
                Console.WriteLine("Введите сумму");
                //double money =  2000;
                while (true)
                {
                    Console.WriteLine("Ваш список");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{products[i]}{prices[i]}");
                    }
                    Console.Write("Выберите товар:(1,2,3...):");
                    string clientsChoice = Console.ReadLine();

                    switch (clientsChoice)
                    {
                        case "1":
                            {
                                Console.Write("Введите кол-во:");
                                int countProduct = int.Parse(Console.ReadLine());
                                cart.Add(prices[0] * countProduct);
                            }
                            break;

                    }
                    Console.WriteLine("Хотите купить еще E(Y/N)");
                    clientsChoice = Console.ReadLine();
                    if (clientsChoice == "N")
                    {
                        break;
                    }
                    
                }
                double SUMM = 0;
                for (int i = 0; i <= cart.Count; i++)
                {
                    SUMM += cart[i];
                }
                Console.WriteLine(SUMM);
            }
            else
            {
                Console.WriteLine("Вы зашли как админ");
            }









        }






    }
    
}
