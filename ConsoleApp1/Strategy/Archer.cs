using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : Shooter
    {
        public Archer(string name) : base(name, 50, 1, 7, 1, 4, 4, 12)
        {

        }

        public override double Attack(Random rnd)
        {
            if (Arrows > 0)
            {
                return DistanceAttack(rnd);
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                return MeleeAttack(rnd);
            }
        }
    }
}
