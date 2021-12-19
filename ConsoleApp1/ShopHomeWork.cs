using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ShopHomeWork
    {
        public static void Shop()
        {
            List<string> product = new List<string>();
            product.Add("Молоко");
            product.Add("Хлеб");
            product.Add("Говядина");
            product.Add("Сахар");
            product.Add("Сыр");
            List<double> coast = new List<double>();
            coast.Add(39.70);
            coast.Add(29.60);
            coast.Add(318.90);
            coast.Add(68.40);
            coast.Add(111.00);
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
                            for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                            {
                                Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                            }
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
                                            product.Add(newProduct);
                                            Console.Write($"Цена в р. за кг. '{newProduct}': ");
                                            double coastNewProduct = double.Parse(Console.ReadLine());
                                            coast.Add(coastNewProduct);
                                            Console.Write("Продолжить добавление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                                                {
                                                    Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                                                }
                                                break;
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
                                            string delProduct = product[delProductNumber - 1];
                                            int indexRemove = product.IndexOf(delProduct);
                                            product.Remove(delProduct);
                                            coast.Remove(indexRemove);
                                            Console.Write("Продолжить удаление?(д/н): ");
                                            exit = Console.ReadLine();
                                            if (exit == "н")
                                            {
                                                Console.WriteLine("Измененный список товаров:");
                                                for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                                                {
                                                    Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                                                }
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
                            for (int i = 0; i < product.Count; i++) //вывод матрицы продуктов и цен
                            {
                                Console.WriteLine($" {i + 1}.{product[i]} - {coast[i]} р/кг");
                            }
                            List<double> shoppingList = new List<double>();
                            List<string> shoppingListProduct = new List<string>();
                            int index = -1;
                            string exit = "д";//складываем покупки в корзину
                            while (exit != "н")
                            {
                                Console.Write("Какой продукт положить в корзину?(№): ");
                                int productTypeNumber = int.Parse(Console.ReadLine());
                                string productType = product[productTypeNumber - 1];
                                shoppingListProduct.Add(productType);
                                Console.Write($"Сколько '{productType}' вам нужно?: ");
                                int amountOfProduct = int.Parse(Console.ReadLine());
                                if (product.Contains(productType))
                                {
                                    index = product.IndexOf(productType);
                                    shoppingList.Add(amountOfProduct * coast[index]);
                                    Console.Write("Продолжить покупки?(д/н): ");
                                    exit = Console.ReadLine();
                                    if (exit == "н") break;
                                }
                            }
                            //печать корзины
                            Console.WriteLine("Ваша корзина покупок:");
                            for (int i = 0; i < shoppingList.Count; i++)
                            {
                                Console.WriteLine($" {i + 1}.'{shoppingListProduct[i]}' на сумму: {shoppingList[i]} р.");
                            }
                            //подсчет суммы корзины
                            for (int i = 0; i < shoppingList.Count; i++)
                            {
                                amountOfPurchase += shoppingList[i];
                            }
                            Console.WriteLine($"Сумма вашей корзины: {amountOfPurchase} р.");
                            if (amountOfPurchase <= allMoney)
                                Console.WriteLine($"Удачная покупка! (Ваших денег: {allMoney} р. достаточно для покупок на {amountOfPurchase} р. Сдача: {allMoney - amountOfPurchase} р.)");
                            else Console.WriteLine($"Не хватает денег! (Сумма покупок: {amountOfPurchase} р. больше, чем у вас денег: {allMoney} р.");
                        }
                        break;
                }
            }
        }
    }
}
