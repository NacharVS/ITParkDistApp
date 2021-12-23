using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product>products=new List<Product>();
            List<Product> cart = new List<Product>();
            string name = Console.ReadLine();
            double count = int.Parse(Console.ReadLine());

            Product bread = new Product("borodinsky hleb",40,80);
            Product beans = new Product("fasol",45.45,8.7);
            //Console.WriteLine($"{bread.shop} {beans.shop}");
            products.Add(bread);
            products.Add(beans);
            products.Add(new Product("Tvorog", 50, 40));
            products.Add(new Product("Yogurt", 50, 40));
            products.Add(new Product("Cheese", 50, 40));
            products.Add(new Product(name, adminPrice, count));
            foreach (var item in products)
            {
                Console.WriteLine($"{item.productName} {item.price} ");
            }
            string neededProd = Console.ReadLine();
            foreach (var item in products)
            {
                if(item.productName==neededProd)
                {
                    cart.Add(item);
                }
            }


            //cart.Add(products.Find(x => x.productName == "fasol"));
            /*int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);

            SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                summIDs[i] = new SummID();
                summIDs[i].rowId = i + 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    summIDs[i].summInCurrentRow += matrix[i, j];
                }
            }
            foreach (var item in summIDs)
            {
                Console.WriteLine($"{item.rowId}) {item.summInCurrentRow}");
            }
            for (int i = 0; i < summIDs.Length-1; i++)
            {
                for (int j = 0; j < summIDs.Length-1-i; j++)
                {
                    int buff1 = 0;
                    int buff2;
                    if (summIDs[j].summInCurrentRow > summIDs[j + 1].summInCurrentRow)
                    { 
                        buff1=summIDs.     
                            
                    }
                }
            }*/
            /*int[] arrayOfMatrixSumRow = new int[10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    
                }
                arrayOfMatrixSumRow[i] = sum;
            }
            Console.WriteLine("Сумма строк:");
            ArrayOperations.ArrayPrint(arrayOfMatrixSumRow);
            Console.WriteLine("Отсортированный массив сумм:");
            ArrayOperations.ArraySorting(arrayOfMatrixSumRow);*/
        }
    }
}
