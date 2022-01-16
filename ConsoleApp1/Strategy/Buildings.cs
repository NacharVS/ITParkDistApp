using System;

namespace ConsoleApp1.Strategy
{
    class Buildings : Unit
    {
        private double _wall;

        public Buildings(string name, int health, int armor) : base(name, health, armor)
        {
            _wall = health;
        }
        internal double Wall
        {
            get { return _wall; }
            set
            {
                if (value <= 0)
                {
                    _wall = 0;
                    Console.WriteLine("Wall is broken");
                }
                else if (value > _maxHealth)
                {
                    _wall = _maxHealth;
                }
                else
                    _wall = value/** (100 - (100 * (armor * 0.06) / (1 + armor * 0.06))) / 100*/;

            }
        }
        public override void Info()
        {
            if(Health>0)
                Console.WriteLine("\t({0}: Wall={1}, HP={2})", name, Math.Round(Wall), Math.Round(Health));
        }
    }
}
