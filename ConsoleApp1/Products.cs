using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Products
    {
        public string name;
        public int price;
        public int quantity;

        public void Product()
        {
            Console.WriteLine($"Наименование:{name}___Цена:{price}___Количество на складе:{quantity}");
        }
    }
}
