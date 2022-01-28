using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class Catapult : BattleUnit
    {
        internal override bool IsCatapult => true;
        public Catapult() : base("Catapulta 1", 200, 20, 4, "Catapulta", 30, 90)
        {
        }

        public override void Info()    /*    Метод информации для катапульты*/
        {
            Console.WriteLine($"{profession}. HP={Health}.Броня={armor}.Минимальный урон={minDamage}.Максимальный урон={maxDamage}");
        }
    }
}
