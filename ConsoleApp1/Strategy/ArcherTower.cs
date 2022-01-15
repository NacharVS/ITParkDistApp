using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ArcherTower : WathingTower
    {
        private Archer[] _archer = new Archer[5];
        private string[] _archersName = new string[] { "Legolaz1", "Legolaz2", "Legolaz3", "Legolaz4", "Legolaz5" };
        private int _garrison;

        public ArcherTower(string name, int garrison) : base(name)
        {
            _garrison = garrison;

            if (garrison < 0)
            {
                Console.WriteLine($"Max archers is {_archer.Length}, min archers is 0.");
            }

            else if (garrison > _archer.Length)
            {
                Console.WriteLine($"Max archers is {_archer.Length}, min archers is 0.");
            }

            else if (garrison <= _archer.Length && garrison >= 0)
            {
                for (int i = 0; i < garrison; i++)
                {
                    _archer[i] = new Archer(_archersName[i]);
                }
            }
        }

        public Archer[] Archer { get => _archer; set => _archer = value; }

        public double DistanceAttack(Random rnd)
        {
            double damage = 0;
            for (int i = 0; i < _garrison; i++)
            {
                damage += _archer[i].DistanceAttack(rnd);
            }

            return damage;
        }
    }
}
