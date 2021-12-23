using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Admin.AddProduct(products, "bread", 20, 10);
            Admin.AddProduct(products, "milk", 20, 5);
            Product.ShowListofProducts(products);

            Client.AddToCart(products, 1, 2);
            Client.AddToCart(products, 2, 1);
            Client.AddToCart(products, 1, 2);
            Client.AddToCart(products, 1, 1);
            Console.WriteLine();

            Console.WriteLine(Client.SolveCost());

            Console.WriteLine();

            Client.ShowCart();


            //string neededProd = Console.ReadLine();

            //foreach (var item in products)
            //{
            //   if(item.productName == neededProd)
            //   {
            //        cart.Add(item);
            //   }
            //}



            //cart.Add(products.Find(x => x.productName == "фасоль"));






            //int[,] matrix = new int[10, 10];
            //ArrayOperations.ArrayGeneration(matrix, 100);

            //SummID[] summIDs = new SummID[10];


            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    summIDs[i] = new SummID();

            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        summIDs[i].rowId = i;
            //        summIDs[i].summInCurrentRow += matrix[i, j];
            //    }
            //}
            //Console.WriteLine();
            //foreach (var item in summIDs)
            //{
            //    Console.WriteLine($"{item.rowId + 1} - {item.summInCurrentRow}");
            //}

            //for (int i = 0; i < summIDs.Length- 1; i++)
            //{
            //    for (int j = 0; j < summIDs.Length - 1 - i; j++)
            //    {
            //        int buff1 = 0;
            //        int buff2 = 0;
            //        if(summIDs[j].summInCurrentRow > summIDs[j + 1].summInCurrentRow)
            //        {
            //            buff1 = summIDs[j].rowId;
            //            buff2 = summIDs[j].summInCurrentRow;
            //            summIDs[j].summInCurrentRow = summIDs[j + 1].summInCurrentRow;
            //            summIDs[j].rowId = summIDs[j + 1].rowId;
            //            summIDs[j + 1].summInCurrentRow = buff2;
            //            summIDs[j + 1].rowId = buff1;

            //        }

            //    }
            //}
            //Console.WriteLine();
            //foreach (var item in summIDs)
            //{
            //    Console.WriteLine($"{item.rowId + 1} - {item.summInCurrentRow}");
            //}

            // 1. Отсортировать номера строк по возрастанию сумм в кажджой строке матрицы.
            // 2. Переделать Магазин из ДЗ2 через классы. 
            // * Все задания выполняем отдельных файлах


        }
        // 1 2 3 - 6      1 3 2
        // 4 4 6 - 14
        // 7 1 2 - 10


    }
}
