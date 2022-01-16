using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ArcherTower : Buildings
    {
        private int _minDamage;
        private int _maxDamage;
        public ArcherTower(string name, int health, int armor, int minDamage, int maxDamage) : base(name, health, armor)
        {
            this._minDamage = minDamage;
            this._maxDamage = maxDamage;
            IsFull = false;
            CanAttack = false;
        }

        //My Attack
        public double Attack(Random rnd, int archerAmount)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(_minDamage, _maxDamage));
            return currentDamage;
        }
        private List<Archer> archers=new List<Archer>();
        public bool IsFull { get; set; }
        public bool CanAttack { get;private set; }
        public void LoadArchers(Archer archer)
        {
            if (archers.Count >= 5)
            {
                Console.WriteLine("Tower is full");
                IsFull = true;
            }
            else
                archers.Add(archer);
        }
        public double Attack(Random rnd)
        {
            double totalDamage = 0;
            if (archers.Count>0)
            {
                foreach(var item in archers)
                {
                    totalDamage += item.RangeAttack(rnd);
                }
            }
            return totalDamage;
        }
    }
}
