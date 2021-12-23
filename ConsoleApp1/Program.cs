using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Products one = new Products();
            //one.name = "Помидоры";
            //one.price = 130;
            //one.quantity = 400;

            //Products two = new Products();
            //two.name = "Бананы";
            //two.price = 70;
            //two.quantity = 200;

            //two.Product();

            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);

            SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                summIDs[i] = new SummID();
            }
            for (int i = 0; i < 10; i++)
            {
                summIDs[0].summInCurrentrow += matrix[0, i];
                summIDs[0].rowId = 1;
            } // тут мы заполнили первый элемент, посчитали сумму первой строчки, чтобы в следующем цикле было с чем сравнивать, соответственно дальше идём со следующей строки

            for (int i = 1; i < 10; i++)
            {
                // создаём переменную, чтобы в неё суммировать значерия в строке
                SummID sum = new SummID
                {
                    summInCurrentrow = 0, // для суммирования
                    rowId = i + 1 // нумерация в массиве с 0, а номер строки это +1
                };

                for (int j = 0; j < 10; j++) // идём по строчке
                {
                    sum.summInCurrentrow += matrix[i, j]; // просуммировали строку и записали
                }

                for (int k = 0; k < i; k++) // тут идём по массиву сумм и сравниваем значения с тем, что посчитали для текущей i строки
                {
                    if (sum.summInCurrentrow < summIDs[k].summInCurrentrow) // если текущая меньше, то сдвигаем
                    {
                        for (int l = i; l > i; l--)
                        {
                            summIDs[l] = summIDs[l - 1];
                        }
                    }
                    else // если нет, то записываем последней
                    {
                        summIDs[k + 1] = sum;
                    }
                   
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(summIDs[i].rowId);
            }
        }
    }
}

