using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                 //КРЕСТЬЯНИН
    class Peasant :MovableUnits
    {
        public int CarryWeight;             /*Переносимый груз крестиянина*/

        public Peasant(string name) : base(name, 30, 0, "Разнорабочий", 4) /*КОНСТРУКТОР Peasan*/ /*Задали Крестиянину  жизнь(30),броня(0),профессия(разнорачбочий),скорость(4)*/
        {

            CarryWeight = 100;
        }

        public void Work()                /*Метод для крестиянина (РАБОТАТЬ)*/
        {
            Console.WriteLine($"{profession} {name} передвигается со скоростью {speed} и может нести {CarryWeight} кг.");
        }
    }
}
