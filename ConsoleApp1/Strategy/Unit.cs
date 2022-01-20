using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        internal double _health;
        internal double _maxHealth;
        internal double _maxArmor;
        public double armor;
        public bool hpBoostStatus;
        private bool frenzyStatus;
        public bool stoneSkinStatus;
        public bool salvationBuffStatus;
        internal virtual bool IsCatapult { get => false; }
        

        public virtual double Health
        {
            get { return _health; }
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Termination();
                }
                //else if (value > _maxHealth)
                //{
                //    _health = _maxHealth;
                //}
                else
                    _health = value/* * ()*/;
            }
        }

        public bool FrenzyStatus { get => frenzyStatus; set => frenzyStatus = value; }

        protected Unit(string name, int health, int armor)
        {
            this.name = name;
            this._health = health;
            this.armor = armor;
            this._maxHealth = health;
            this._maxArmor = armor;
            this.hpBoostStatus = false;
            this.FrenzyStatus = false;
            this.stoneSkinStatus = false;
            this.salvationBuffStatus = false;
            Creation();
        }
        public void Creation()
        {
            Console.WriteLine($"{name} is created with {Health} HP, {armor} armor ({DamageReduction()} incoming damage multiplier)");
        }
        public void Termination()
        {
            Console.WriteLine($"{name} is terminated with {_health} HP");
        }
        public virtual void Info()
        {
            Console.WriteLine($"\t({name} HP={Math.Round(Health)})");
        }
        public double DamageReduction()
        {
            double damageReduction = Math.Ceiling(100-(100 * (armor * 0.06) / (1 + armor * 0.06)))/100;
            //Console.WriteLine($"   Damage reduction {name} is {damageReduction:0.00}");
            return damageReduction;
        }
    }
}
