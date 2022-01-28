using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class Bildings : Unit           /*НАСЛЕДУЕМ ОТ КСЛАССА Unit*/
    {
        private double _wall;     /*броня у здания*/

        public Bildings(string name, int healt, int armor) : base(name, healt, armor)   /* <---КОНСТРУКТОР*/
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
            Console.WriteLine($"{name} {_wall} {Health}");
        }
    }
}
