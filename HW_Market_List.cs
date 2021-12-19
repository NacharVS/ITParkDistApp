using System;
using System.Collections.Generic;

namespace MarketList
{
    class Program

        /* Реализовать каталог товаров с ценами за 1 единицу/1 кг. Приложение, предлагает войти как администратору или как клиенту. 

1.1 Администратор может добавлять новые товары/удалять старые.Приложение спрашивает хотите продолжить редактирование каталога или нет.Если нет, то возврат к выбору админ/клиент.

1.2 При авторизации в качестве клиента, предлагается ввести количество денежных единиц.

Клиент может выбирать товар и выбирать количество товара. после выбора товара и ввода количества товара, клиент может перейти к оплате или продолжить выбор, тем самым формируя список покупок.Формируется список покупок и подсчет общей стоимости.После того, как клиент перешёл к оплате, осуществляется проверка.. Если введенное в начале число денежных единиц недостаточно, тогда появляется соответствующее уведомление.
Если Достаточно, тогда покупка проходит, и осуществляется подсчет сдачи необходимой к возврату */

    {
        static void Main(string[] args)
          {


            var listofprice = new List<double>() { 250, 130, 80, 70, 65, 50, 187, 300, 350, 90 };
            var listofproduct = new List<string>(){
            "Сыр", "Масло","Апельсины","Груши","Яблоки","Хлеб","Курица","Говядина","Форель","Мука" };
            Console.WriteLine("Вы администратор или клиент? (Напишите администратор или клиент)");
            string enter = Console.ReadLine();
            
            if (enter == "администратор")
            {
                string ChoiseContin = "да";

                while (ChoiseContin == "да")
                {
                    
                    Console.Write("Вы хотите добавть продукты или удалить?(добавить/удалить): ");
                    string AdChoise = Console.ReadLine();
                    if (AdChoise == "удалить")
                    {
                        for (int i = 0; i < listofproduct.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listofproduct[i]} {listofprice[i]}");
                        }
                        Console.WriteLine("Выберите товар который хотите удалить: ");
                        string AdDelChoise = Console.ReadLine();
                        if (listofproduct.Remove(AdDelChoise))
                        {
                            Console.WriteLine("Укажите цену товара, которого хотите удалить: ");
                            int AdDelprice = int.Parse(Console.ReadLine());
                            if (listofprice.Remove(AdDelprice))
                            {
                                Console.WriteLine("Товар удален!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Такого товара нет. Повторите ввод");
                        }
                    }
                    if (AdChoise == "добавить")
                    {
                        Console.WriteLine("Введите новую цену");
                        int Newpricee = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новый продукт");
                        string Newproduct = Console.ReadLine();
                        listofprice.Add(Newpricee);
                        listofproduct.Add(Newproduct);
                    }
                    Console.WriteLine("Хотите продолжить?(да/нет): ");
                    ChoiseContin = Console.ReadLine();

                }
                if (enter == "администратор" && ChoiseContin == "да")
                {
                                        
                }
                else
                {
                    Console.Write("Введите количество денежных средств ");
                    double Money = double.Parse(Console.ReadLine());
                    var Clientlist = new List<string>();
                    double ClientCost = 0;
                    double Change = 0;
                    while (true)
                    {

                        for (int i = 0; i < listofproduct.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listofproduct[i]} {listofprice[i]}");
                        }
                        Console.Write("Выберите товар (Словом с учетом регистра (Сыр, Масло...): ");
                        string clientChoise = Console.ReadLine();
                        Console.Write("Выберите количество в килограммах (0,1, 0,2... 1,1, 1,2...): ");
                        double quantity = double.Parse(Console.ReadLine());

                        if (Change + ClientCost <= Money)
                        {

                            for (int j = 0; j < listofproduct.Count; j++)
                            {
                                if (clientChoise == listofproduct[j])
                                {


                                    Clientlist.Add(listofproduct[j]);
                                    ClientCost += (quantity * listofprice[j]);
                                    Change = Money - ClientCost;
                                    Console.WriteLine($"Вы вбрали {listofproduct[j]} по цене {listofprice[j]} за единицу");

                                    Console.Write("В вашей корзине: ");
                                    foreach (var item in Clientlist)
                                    {
                                        Console.WriteLine($"{item} ");
                                    }
                                    Console.WriteLine($"Общая стоимость: {ClientCost}");


                                }


                            }

                            Console.WriteLine($"Оставшиеся средства: {Change}");

                            Console.WriteLine("Что-нибудь еще? (Да/Нет)");
                            string clientContinue = Console.ReadLine();

                            if (clientContinue == "Нет")

                            {
                                Console.WriteLine($"Вы купили продукты общей стоимостью: {ClientCost}");
                                Console.WriteLine($"Ваша сдача: {Change}");
                                break;
                            }



                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств. Повтрите выбор");
                            Console.WriteLine($"У Вас осталось: {Change}");
                        }



                    }

                }

            }
            else
            {
                Console.Write("Введите количество денежных средств ");
                double Money = double.Parse(Console.ReadLine());
                var Clientlist = new List<string>();
                double ClientCost = 0;
                double Change = 0;
                while (true)
                {
                   
                        for (int i = 0; i < listofproduct.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listofproduct[i]} {listofprice[i]}");
                        }
                        Console.Write("Выберите товар (Словом с учетом регистра (Сыр, Масло...): ");
                        string clientChoise = Console.ReadLine();
                    Console.Write("Выберите количество в килограммах (0,1, 0,2... 1,1, 1,2...): ");
                    double quantity = double.Parse(Console.ReadLine());

                    if (Change + ClientCost <= Money)
                    {

                        for (int j = 0; j < listofproduct.Count; j++)
                        {
                            if (clientChoise == listofproduct[j])
                            {
                                

                                Clientlist.Add(listofproduct[j]);
                                ClientCost += (quantity * listofprice[j]);
                                Change = Money - ClientCost;
                                Console.WriteLine($"Вы вбрали {listofproduct[j]} по цене {listofprice[j]} за единицу");

                                Console.Write("В вашей корзине: ");
                                foreach (var item in Clientlist)
                                {
                                    Console.WriteLine($"{item} ");
                                }
                                Console.WriteLine($"Общая стоимость: {ClientCost}");


                            }


                        }

                        Console.WriteLine($"Оставшиеся средства: {Change}");

                        Console.WriteLine("Что-нибудь еще? (Да/Нет)");
                        string clientContinue = Console.ReadLine();

                        if (clientContinue == "Нет")

                        {
                            Console.WriteLine($"Вы купили продукты общей стоимостью: {ClientCost}");
                            Console.WriteLine($"Ваша сдача: {Change}");
                            break;
                        }
                        


                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств. Повтрите выбор");
                        Console.WriteLine($"У Вас осталось: {Change}");
                    }


                    
                }                        
                    
            }
            
            










        }
    }
}
