using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(323);
            list.Add(2); 
            list.Add(432);
            list.Add(342); 
            list.Add(6556);
            list.Add(222);
            list.Add(43);
            if(list.Contains(222))
                Console.WriteLine(list.IndexOf(222));
            else
            {
                Console.WriteLine("not found");
            }

            Console.WriteLine("updated");

            // Создать каталог товаров(Наименование и цена за единицу). 
            // Должна быть возможность добавления новых товаров. (admin) и удаление. 
            // Покупка нескольких товаров(ввод наименования и количества товара). Организовать подсчет общей стоимости 
            //покупки, проверку на наличие необходимых финансов. Если покупка прошла, то вывести полный список купленных товаров и их стоимость.
           

        }
        
    }
}
