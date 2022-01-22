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
            //-------------------Стратегия----------------------------------------
            Random rnd = new Random();
            Peasant peasant1 = new Peasant("Ivan"); /*Создание экземпляра */
            Healer healer = new Healer("Gendalf", 20);
            Archer archer = new Archer("Legolas");

            /*peasant1.Work(); */  /*вызов метода(Move или Work)*/
            /*tower1.Observe();*/   /*Вызов метода Observe(Наблюдать)*/

            //peasant1.Move();

            //archer.RangeAttack(healer, rnd);
            //healer.Info();
            //archer.RangeAttack(healer, rnd);
            //healer.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();

            //healer.Heal(peasant1);
            //peasant1.Move();

            Console.WriteLine("--------------------Бой 2х солдат-------------------------------------");

            Warrior war1 = new Warrior("Bob");   /*Создание солдата*/
            Warrior war2 = new Warrior("John");

            Battle.Fight(war1, war2);  /*стрелок атакует солдата*/


            Console.WriteLine("---------------------Бой  башни с лучниками и солдата--------------------------");

            ArcherTower archerTower1 = new ArcherTower();
            Console.WriteLine($"{archerTower1.name} атаковал {war1.name}a");
            for (int i = 0; i <= 1; i++)
            {
                archerTower1.LoadArchers(archer);
            }
            Battle.Fight(archerTower1, war1);
            Console.WriteLine("-------------------------Бой между башнями  и солдата----------------------------------------------------------");

            WathingTower wTower = new WathingTower();  /*Создание водонапорной башни*/
            wTower.Observe();
            Battle.Fight(wTower, war1);
            wTower.Info();
            Console.WriteLine("-------------------------------Катапульта--------------------------------------------");
            Catapult catapult1 = new Catapult();
            catapult1.Info();
            Battle.Fight(wTower, catapult1);
            Console.WriteLine("-------------------------------------------------------------------------------");







            //-------------------------------------------------------------------МАГАЗИН-------------------------------------------------------
            //List<Product> products = new List<Product>();
            //products.Add(new Product("Beer", 100, 27));
            //products.Add(new Product("Vodka", 450, 30));
            //products.Add(new Product("Seledka", 250, 11));
            //products.Add(new Product("Lavash", 50, 18));
            //products.Add(new Product("Juice", 190, 25));
            //Выбор входа----------------------------------------
            //Console.Write("Client and Admin:  ");


            //string s = Console.ReadLine();
            //if (s == "Admin")
            //{
            //Product.SwowListOfProduct(products);
            //Console.WriteLine("ADD/Remove(+/-)");
            //string edit = Console.ReadLine();
            //switch (edit)
            //{
            //case "+":
            //Добавление нового продукта----------------------------------------------

            //Console.WriteLine("New product name");
            //string NewProductName = Console.ReadLine();

            //Console.WriteLine("New product price");
            //double NewProductPrice = double.Parse(Console.ReadLine());

            //Console.WriteLine("New product count");
            //int NewProductcount = int.Parse(Console.ReadLine());


            //Admin.AddProduct(products, NewProductName, NewProductPrice, NewProductcount);
            //Console.WriteLine("New List");
            //Product.SwowListOfProduct(products);
            //break;
            //Удаление продукта---------------------------------------------------------
            //case "-":

            //    Console.WriteLine("Remove product №:");
            //    int RemoveProduct = int.Parse(Console.ReadLine());

            //    Admin.RemoveProduct(products, RemoveProduct);
            //    Console.WriteLine("New List");
            //    Product.SwowListOfProduct(products);

            //    break;
            //}
            //}
            //if (s == "Client")
            //{
            //    Console.Write("Your credit limit: ");
            //    double Summa = double.Parse(Console.ReadLine());

            //Выбор продукта-------------------------------------------------------------------------
            //Console.WriteLine("Сhoose a product:1 of 5");
            //Product.SwowListOfProduct(products);

            //int choiceProduct = int.Parse(Console.ReadLine());
            //Console.WriteLine("Product Quantity");
            //int countedProduct = int.Parse(Console.ReadLine());
            //Client.AddToCart(products, choiceProduct, countedProduct);

            //Console.WriteLine("Your choice");


            //while (true)
            //{
            //    Console.WriteLine("Do you want to buy something else?(Y/N)");

            //    string still = Console.ReadLine();
            //    switch (still)
            //    {
            //        case "Y":

            //Console.WriteLine("Сhoose a product:1 of 5");
            //Product.SwowListOfProduct(products);

            //int NextchoiceProduct = int.Parse(Console.ReadLine());
            //Console.WriteLine("Product Quantity");
            //int NextcountedProduct = int.Parse(Console.ReadLine());
            //Client.AddToCart(products, NextchoiceProduct, NextcountedProduct);

            //            break;
            //    }
            //    if (still == "N")
            //    {
            //        break;
            //    }

            //}

            //Console.WriteLine("Your choice");
            //Client.ShowCart();
            //Console.WriteLine($"Purchase amount: {Client.Summ()}p.");
            //if (Summa < Client.Summ())
            //{
            //    Console.WriteLine("Not enough money");
            //}

            //}

        }
    }
}
