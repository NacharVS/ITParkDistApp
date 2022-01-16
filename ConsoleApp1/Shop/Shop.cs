using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop
    {
        public static void ShopMain()
        {
            var groceryList = new List<Product>();
            groceryList.Add(new Product("Молоко", 39.70));
            groceryList.Add(new Product("Хлеб", 29.60));
            groceryList.Add(new Product("Говядина", 318.90));
            groceryList.Add(new Product("Сахар", 68.40));
            groceryList.Add(new Product("Сыр", 111.00));
            string mode = "";
            while (mode != "в")
            {
                Console.Write("Админ(а)/Клиент(к)/Выход(в)?: ");
                mode = Console.ReadLine();
                switch (mode)
                {
                    case "а":
                        {
                            Console.WriteLine("Текущий список товаров:");
                            Product.ShowListofProducts(groceryList);//вывод матрицы продуктов и цен
                            Console.Write("Добавить или удалить товары?(+/-): ");
                            string editMode = Console.ReadLine();
                            switch (editMode)
                            {
                                case "+":
                                    {
                                        string exit = "д";
                                        while (exit != "н")
                                        {
                                            Console.Write("Наименование добавляемой позиции?: ");
                                            string newProduct = Console.ReadLine();
                                            Console.Write($"Цена в р. за кг. '{newProduct}': ");
                                            double coastNewProduct = double.Parse(Console.ReadLine());
                                            Admin.AddProduct(groceryList, newProduct, coastNewProduct);
                                            Console.Write("Продолжить добавление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                Product.ShowListofProducts(groceryList);//вывод матрицы продуктов и цен
                                            }
                                            else if (exit == "д") continue;
                                            else Console.WriteLine("Ошибка ввода: только 'д' или 'н'");
                                        }
                                    }
                                    break;
                                case "-":
                                    {
                                        string exit = "д";
                                        while (exit != "н")
                                        {
                                            Console.Write("Что удаляем?(№): ");
                                            int delProductNumber = int.Parse(Console.ReadLine());
                                            Admin.RemoveProduct(groceryList, delProductNumber);
                                            Console.Write("Продолжить удаление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                Product.ShowListofProducts(groceryList);
                                                break;
                                            }
                                            else Console.Write(" Только 'д' или 'н'");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "к":
                        {
                            double amountOfPurchase = 0;
                            Console.Write("Сколько у вас денег на покупки?: "); //запрос имеющейся суммы денег
                            int allMoney = int.Parse(Console.ReadLine());
                            Console.WriteLine("Список продуктов:");
                            Product.ShowListofProducts(groceryList);
                            int index = -1;
                            string exit = "д";//складываем покупки в корзину
                            while (exit != "н")
                            {
                                Console.Write("Какой продукт положить в корзину?(№): ");
                                int productTypeNumber = int.Parse(Console.ReadLine());
                                Console.Write($"Сколько вам нужно?: ");
                                double amountOfProduct = int.Parse(Console.ReadLine());
                                Client.AddToCart(groceryList, productTypeNumber, amountOfProduct);
                                Console.Write("Продолжить покупки?(д/н): ");
                                exit = Console.ReadLine();
                                if (exit == "н") break;
                            }
                            Console.WriteLine("Ваша корзина покупок:"); //печать корзины
                            Client.ShowCart();

                            Console.WriteLine("Есть скидочный купон?(+/-) ");
                            string couponFlag = Console.ReadLine();
                            if (couponFlag == "+")
                            {
                                Console.WriteLine($"Сумма вашей корзины: {Convert.ToString(Client.UseCoupon(Client.SolveCost())):0.00}");
                                if (Client.UseCoupon(Client.SolveCost()) <= allMoney)
                                    Console.WriteLine($"Удачная покупка! (Ваших денег: {allMoney:0.00} р. достаточно для покупок на {Client.UseCoupon(Client.SolveCost()):0.00} р. Сдача: {allMoney - Client.UseCoupon(Client.SolveCost()):0.00} р.)");
                                else Console.WriteLine($"Не хватает денег! (Сумма покупок: {Client.UseCoupon(Client.SolveCost()):0.00} р. больше, чем у вас денег: {allMoney:0.00} р.");
                            }
                            else
                            {
                                Console.WriteLine($"Сумма вашей корзины: {Convert.ToString(Client.SolveCost()):0.00}");
                                if (Client.SolveCost() <= allMoney)
                                    Console.WriteLine($"Удачная покупка! (Ваших денег: {allMoney:0.00} р. достаточно для покупок на {Client.SolveCost():0.00} р. Сдача: {allMoney - Client.SolveCost():0.00} р.)");
                                else Console.WriteLine($"Не хватает денег! (Сумма покупок: {Client.SolveCost():0.00} р. больше, чем у вас денег: {allMoney:0.00} р.");
                            }
                        }
                        break;
                }
            }
        }
    }
}
