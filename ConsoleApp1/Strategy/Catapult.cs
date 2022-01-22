using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                       //Катапульта
    class Catapult : BattleUnits
    {
        internal override bool IsCatapult => true;

        public Catapult() : base("Катапульта №1", 200, 20, "Катапульта", 4, 30, 90)  /* Конструктор катапульты*/
        {

        }
        public override void Info()    /*    Метод информации для катапульты*/
        {
            Console.WriteLine($"{profession}. HP={Healt}.Броня={armor}.Минимальный урон={minDamage}.Максимальный урон={maxDamage}");
        }

    }
}
