using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ConsoleApp1.Strategy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double [] array=new double [10];
            //for (int i = 0; i < array.Length; i++)
            //    array[i] = i + 1.1;
            //Console.WriteLine(ArrayMaxValue.MaxIndex(array));
            //array.All
            //26.12.21: 8 лекция
            //Peasant peasant1 = new Peasant("Ivan");
            //WathingTower tower = new WathingTower();
            //Soldier soldier = new Soldier("Rodion");
            //soldier.AttackPeasant(peasant1);
            //peasant1.Move
            //peasant1.Work();
            //tower.Observe();
            //Random rnd = new Random();
            //Peasant peasant1 = new Peasant("Ivan");
            //BattleUnit soldier = new BattleUnit("Rodion");
            //soldier.Upgrade();
            //peasant1.Move();
            //soldier.AttackPeasant(peasant1, rnd);
            //peasant1.Move();
            //soldier.AttackPeasant(peasant1, rnd);
            //soldier.AttackPeasant(peasant1, rnd);
            //soldier.AttackPeasant(peasant1, rnd);
            //soldier.AttackPeasant(peasant1, rnd);
            //soldier.AttackPeasant(peasant1, rnd);
            //peasant1.Move();
            //Random rnd = new Random();
            //Peasant peasant1 = new Peasant("Ivan");
            //Archer archer = new Archer("Legolas");
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //ДЗ
            //HEALER
            // 1.Добавить методы лечения юнитов для класса Healer
            // +порог лечения, ресурс лечения (мана), кол-во лечения
            // 2.добавить метод починки зданий для классов Peasant
            // 3. Добавить методы лечения юнитов для класса hospital

            //-------------------------------------------------------------------

            List<Product> products = new List<Product>();
            //List<Product> cart = new List<Product>();
            //string name = Console.ReadLine();
            //double count = int.Parse(Console.ReadLine());

            //Product bread = new Product("borodinsky hleb", 40, 80);
            //Product beans = new Product("fasol", 45.45, 8.7);
            
            products.Add(new Product("Tvorog", 50, 40));
            products.Add(new Product("Yogurt", 50, 40));
            products.Add(new Product("Cheese", 50, 40));
            Product.ShowListofProducts(products);
            Console.WriteLine("newList");
            Admin.AddProduct(products, "Tea", 130, 20);
            Product.ShowListofProducts(products);
            Console.WriteLine("delete");
            Admin.RemoveProduct(products, 2);
            Product.ShowListofProducts(products);
            //products.Add(new Product(name, adminPrice, count));
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.productName} {item.price} ");
            //}
            //string neededProd = Console.ReadLine();
            //foreach (var item in products)
            //{
            //    if (item.productName == neededProd)
            //    {
            //        cart.Add(item);
            //    }
            //}


            //cart.Add(products.Find(x => x.productName == "fasol"));
        }
    }
}
