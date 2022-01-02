using ConsoleApp1.Homework5.Exercise2.Classes;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework5.Exercise2.Homework5.Shop();




            //Product.ShowListofProducts(products);

            //Client.AddToCart(products, 2, 2);
            //Client.AddToCart(products, 2, 1);
            //Client.AddToCart(products, 3, 2);
            //Client.AddToCart(products, 3, 1);
            //Client.AddToCart(products, 3, 1);
            //Client.AddToCart(products, 5, 1);
            //Client.AddToCart(products, 5, 2);
            //Client.AddToCart(products, 4, 1);
            //Client.AddToCart(products, 1, 4);

            //Client.ShowCart();

            //Console.WriteLine(Client.SolveCost());





            //Homework5.Exercise1.Homework5.Exercise1();
            //Homework5.Exercise2.Homework5.Shop();


            //List<string[]> List = new List<string[]>();

            //string[] arr = new string[2];

            //List.Add(new string[2] { "Молоко", "60" });
            //List.Add(new string[2] { "Масло", "100" });
            //List.Add(new string[2] { "Хлеб", "40" });
            //List.Add(new string[2] { "Шоколад", "110" });
            //List.Add(new string[2] { "Яйца", "80" });

            //while (true)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Введите под каким пользователем вы хотите войти в программу");
            //    Console.WriteLine("(1) Администратор; (2) Покупатель");
            //    int command = int.Parse(Console.ReadLine());
            //    string prise;
            //    bool isContinueAdmin = true;
            //    bool isContinueClient = true;

            //    switch (command)
            //    {
            //        case 1:
            //            {
            //                while (isContinueAdmin)
            //                {
            //                    string product;

            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Введите команду:");
            //                    Console.WriteLine("(1) Добавить товар (2) Удалить товар");
            //                    command = int.Parse(Console.ReadLine());
            //                    if (command == 1)
            //                    {
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Актуальный перечень товаров: ");
            //                        foreach (var item in List)
            //                        {
            //                            Console.WriteLine("товар - " + item[0] + " " + "цена - " + item[1]);
            //                        }
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Введите наменование для добавления товара: ");
            //                        product = Console.ReadLine();
            //                        Console.WriteLine("Введите цену товара: ");
            //                        prise = Console.ReadLine();
            //                        List.Add(new string[2] { product, prise });
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine($"Товар {product} успешно добавлен");
            //                        Console.WriteLine(" ");
            //                        foreach (var item in List)
            //                        {
            //                            Console.WriteLine("товар - " + item[0] + " " + "цена - " + item[1]);
            //                        }
            //                    }
            //                    else if (command == 2)
            //                    {
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Актуальный перечень товаров: ");
            //                        foreach (var item in List)
            //                        {
            //                            Console.WriteLine("товар - " + item[0] + " " + "цена - " + item[1]);
            //                        }
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Введите наменование товара для удаления: ");
            //                        product = Console.ReadLine();

            //                        //Поиск продукта и его удаление
            //                        foreach (var item in List)
            //                        {
            //                            if (product == item[0])
            //                            {
            //                                List.Remove(item);
            //                                break;
            //                            }
            //                        }

            //                        Console.WriteLine(" ");
            //                        Console.WriteLine($"Товар {product} успешно удален");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Неправильный ввод");
            //                    }

            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Продолжить как администратор: (1) - да  (2) - нет");
            //                    command = int.Parse(Console.ReadLine());

            //                    if (command == 1)
            //                    {
            //                        isContinueAdmin = true;
            //                    }
            //                    else if (command == 2)
            //                    {
            //                        isContinueAdmin = false;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Неправильный ввод");
            //                    }

            //                }
            //            }
            //            break;


            //        case 2:
            //            {
            //                string product;

            //                while (isContinueClient)
            //                {
            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Внесите денежную сумму:");

            //                    int my_money = int.Parse(Console.ReadLine());

            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Выберете продукт из списка (написать наименование продукта): ");

            //                    foreach (var item in List)
            //                    {
            //                        Console.WriteLine("товар - " + item[0] + " " + "цена - " + item[1]);
            //                    }

            //                    Console.WriteLine(" ");
            //                    product = Console.ReadLine();

            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Введите количество");

            //                    //Ввод количества товара
            //                    Console.WriteLine(" ");
            //                    int amount = int.Parse(Console.ReadLine());
            //                    int priseInt = 0;

            //                    //Поиск продукта и вычисление его цены
            //                    foreach (var item in List)
            //                    {
            //                        if (product == item[0])
            //                        {
            //                            priseInt = int.Parse(item[1]);
            //                            break;
            //                        }
            //                    }

            //                    int sum = priseInt * amount; //Сумма покупки
            //                    int odd_money = 0; //Сдача

            //                    if (my_money >= sum)
            //                    {
            //                        odd_money = my_money - sum;
            //                        Console.WriteLine($"Вы купили товар - {product} в количестве - {amount} шт., сумма покупки составила - {sum}, ваша сдача - {odd_money}");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Недостаточно средств");

            //                    }

            //                    Console.WriteLine(" ");
            //                    Console.WriteLine("Продолжить покупки: (1) - да  (2) - нет");
            //                    command = int.Parse(Console.ReadLine());

            //                    if (command == 1)
            //                    {
            //                        isContinueClient = true;
            //                    }
            //                    else if (command == 2)
            //                    {
            //                        isContinueClient = false;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("Неправильный ввод");
            //                    }
            //                }



            //            }
            //            break;


            //        default:
            //            Console.WriteLine("Неправильный ввод");
            //            break;
            //    }


            //}
        }
    }
}
