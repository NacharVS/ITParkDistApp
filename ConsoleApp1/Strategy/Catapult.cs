using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Catapult : Shooter
    {
        internal override bool IsCatapult => true;

        public Catapult() : base("Catapult", 100, 1, 2, 1, 4, 20, 40)
        {
            _arrows = 100;
        }

        public override double Attack(Random rnd)
        {
            if (Arrows > 0)
            {
                return DistanceAttack(rnd);
            }
            else
            {
                return 0;
            }
        }

        public override void Info()
        {
            Console.WriteLine($"Name:{Name}/ health:{Health}/ armor:{Armor}/ speed:{Speed} ");
        }
    }
}
