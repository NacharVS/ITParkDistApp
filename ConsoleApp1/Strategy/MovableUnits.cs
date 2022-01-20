using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        public string profession;
        public int speed;
        public int lvl;
        public override double Health
        {
            get { return _health; }
            set
            {
                //if (Salvation) Salvation
                //{
                //    _health = 0;
                //    Termination();
                //}
                //else if (value > _maxHealth)
                //{
                //    _health = _maxHealth;
                //}
                //else
                //    _health = value/* * ()*/;
            }
        }

        private void SalvationActivate()
        {

        }
        public void SalvationBuff(MovableUnits unit)
        {
            unit.salvationBuffStatus = true;
            Console.WriteLine($"{name} get SalvationBuff to {unit} (devine touch:)!");
        }
        public MovableUnits(string name, int health, int armor, string professionParam, int speedParam) : base(name, health, armor)
        {
            profession = professionParam;
            speed = speedParam;
            lvl = 0;
        }

        public void Move()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Has {Health} ");
        }
    }
}
