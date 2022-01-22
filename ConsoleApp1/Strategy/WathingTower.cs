using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                   //ВОДОНАПОРНАЯ БАШНЯ
    class WathingTower : Buildings
    {
        public WathingTower() : base("Водонапорная башня", 100, 20)  /*Конструктор WathingTower*/ /*Задали название башни,здоровье башни,броню башни*/
        {

        }

        public void Observe()   /*Метод наблюдения для башни*/
        {
            Console.WriteLine($"{name} наблюдает.Здоровье башни {Healt } HP,состояние брони:{armor}");
        }
    }
}
