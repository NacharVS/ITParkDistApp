using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
                              //НЕДВИЖУЮЩИЕСЯ ЮНИТЫ (ЗДАНИЯ,БАШНИ)------------------------
    class Buildings : Unit           /*НАСЛЕДУЕМ ОТ КСЛАССА Unit*/
    {
        private double _wall;     /*броня у здания*/

        public Buildings(string name, int healt, int armor) : base(name, healt, armor)   /* <---КОНСТРУКТОР*/
        {
            Wall = healt;   /* Количество здоровья у здания*/
        }

        public double Wall { get => _wall; set => _wall = value; }

        private void WallIsDestroyed()
        {
            System.Console.WriteLine("Башня разрушилась");
        }
        public override void Info()
        {
            Console.WriteLine($"{name} {_wall} {Healt}");
        }
    }
}
