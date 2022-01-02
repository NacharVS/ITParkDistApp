using ConsoleApp1.Homework5.Exercise2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework5.Exercise2
{
    public partial class Homework5
    {
        public static void Shop()
        {
            bool isContinueAdmin = true;
            bool isContinueClient = true;

            List<Product> products = new List<Product>();
            products.Add(new Product("Хлеб", 42, 20));
            products.Add(new Product("Масло", 120, 23));
            products.Add(new Product("Йогурт", 36, 100));
            products.Add(new Product("Молоко", 47, 30));
            products.Add(new Product("Кофе", 300, 50));

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Введите под каким пользователем вы хотите войти в программу: ");
                Console.WriteLine("(1) Администратор; (2) Покупатель");
                Console.WriteLine();

                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        {
                            while (isContinueAdmin)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("Введите команду:");
                                Console.WriteLine("(1) Добавить товар (2) Удалить товар");
                                command = int.Parse(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("Актуальный перечень товаров: ");

                                Console.WriteLine();

                                Product.ShowListofProducts(products);

                                if (command == 1)
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите наименование продукта: ");
                                    string nameProduct = Console.ReadLine();

                                    Console.WriteLine(" ");
                                    Console.WriteLine("Введите цену продукта: ");
                                    int priceProduct = int.Parse(Console.ReadLine());

                                    Console.WriteLine(" ");
                                    Console.WriteLine("Ведите количество продукта: ");
                                    int countProduct = int.Parse(Console.ReadLine());

                                    admin.AddProduct(products, nameProduct, priceProduct, countProduct);
                                }

                                if (command == 2)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Ведите номер продукта для его удаления: ");
                                    int numberProduct = int.Parse(Console.ReadLine());

                                    admin.RemoveProduct(products, numberProduct);
                                }

                                Console.WriteLine(" ");
                                Console.WriteLine("Обновленный список товаров: ");

                                Product.ShowListofProducts(products);

                                Console.WriteLine(" ");
                                Console.WriteLine("Продолжить как администратор: (1) - да  (2) - нет");
                                command = int.Parse(Console.ReadLine());

                                if (command == 1)
                                {
                                    isContinueAdmin = true;
                                }
                                else if (command == 2)
                                {
                                    isContinueAdmin = false;
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Неправильный ввод");
                                }
                            }

                        }
                        break;
                    case 2:
                        {
                            Client client = new Client();

                            Console.WriteLine(" ");
                            Console.WriteLine("Добро пожаловать в наш магазин: ");

                            Console.WriteLine(" ");
                            Console.WriteLine("Введите сумму денег: ");
                            int my_money = int.Parse(Console.ReadLine());

                            Product.ShowListofProducts(products);
                            Console.WriteLine(" ");
                            Console.WriteLine("Выберете продукт из списка и количество : ");
                            int numberInList = int.Parse(Console.ReadLine());
                            double count = double.Parse(Console.ReadLine());

                            client.AddToCart(products, numberInList, count);

                            Console.WriteLine(" ");
                            Console.WriteLine($"Ваша корзина (продукт/количество):");
                            client.ShowCart();



                            Console.WriteLine(" ");
                            Console.WriteLine("Оплатить товар: (1), продолжить покупки: (2)");
                            command = int.Parse(Console.ReadLine());


                            if (command == 2)
                            {
                                while (isContinueClient == true)
                                {
                                    Product.ShowListofProducts(products);
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Выберете продукт из списка и количество : ");
                                    numberInList = int.Parse(Console.ReadLine());
                                    count = double.Parse(Console.ReadLine());

                                    client.AddToCart(products, numberInList, count);

                                    Console.WriteLine(" ");
                                    Console.WriteLine($"Ваша корзина (продукт/количество):");
                                    client.ShowCart();

                                    Console.WriteLine(" ");
                                    Console.WriteLine("Оплатить товар: (1), продолжить покупки: (2)");
                                    command = int.Parse(Console.ReadLine());

                                    if (command == 2)
                                    {
                                        isContinueClient = true;
                                    }
                                    else if (command == 1)
                                    {
                                        isContinueClient = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("Неправильный ввод");
                                    }
                                }
                            }
                            else if (command == 1)
                            {
                                isContinueClient = false;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Неправильный ввод");
                            }

                            double sum = client.SolveCost();
                            double odd_money;
                            double discont = client.UseCoupon(sum);
                            if (my_money >= client.SolveCost())
                            {
                                odd_money = my_money - sum - discont;
                                Console.WriteLine(" ");
                                Console.WriteLine($"Ваша корзина (продукт/количество):");
                                Console.WriteLine($"-----------------------------------------------------");
                                client.ShowCart();
                                Console.WriteLine($"-----------------------------------------------------");
                                Console.WriteLine($"Cумма покупки составила           {client.SolveCost()}");
                                Console.WriteLine($"Скидка составила                  {discont}");
                                Console.WriteLine($"Итого                             {sum - discont}");
                                Console.WriteLine($"Ваша сдача                        {odd_money}");
                                Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                Console.WriteLine("      Спасибо за покупку, приходите к нам еще!");
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Недостаточно средств");

                            }

                        }
                        break;
                }
            }
        }
    }
}
