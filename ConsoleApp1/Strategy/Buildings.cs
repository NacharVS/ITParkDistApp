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
        public int wall;     /*броня у здания*/

        public Buildings(string name, int healt, int armor) : base(name, healt, armor)   /* <---КОНСТРУКТОР*/
        {
            wall = healt;   /* Количество здоровья у здания*/
        }
    }
}
