using ConsoleApp1.Homework5.Exercise1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Homework5.Exercise1
{
    public partial class Homework5
    {
        private static void RandomMatrix(int[,] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 10);
                    Console.Write($" {arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } 

        public static void Exercise1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int[,] arrey1 = new int[a, b];

            RandomMatrix(arrey1);

            //Row rowArr1 = new Row();
            Row[] rowArr = new Row[a];
            int sum = 0;
            List<Row> list_orig = new List<Row>();

            for (int i = 0; i < a; i++)
            {
                rowArr[i] = new Row();

                for (int j = 0; j < b; j++)
                {
                    sum = sum + arrey1[i,j];
                }

                rowArr[i].index = i;
                rowArr[i].sum = sum;
                list_orig.Add(rowArr[i]);
                sum = 0;
                
                Console.WriteLine($" {rowArr[i].index} {rowArr[i].sum}");
            }

            List<Row> list_sort = new List<Row>();
            Row CurRow = null;

            while (list_orig.Count > 0)
            {
                sum = list_orig.First().sum;
                foreach (var item in list_orig)
                {
                    if(item.sum <= sum)
                    {
                        sum = item.sum;
                        CurRow = item;
                    }
                }

                list_sort.Add(CurRow);
                list_orig.Remove(CurRow);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"После сортаровки:");
            foreach (var item in list_sort)
            {
                Console.WriteLine($" {item.index} -- {item.sum}");
            }

        }

    }
}
