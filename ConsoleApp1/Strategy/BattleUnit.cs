using System;

namespace ConsoleApp1.Strategy
{
    class Warrior : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public Warrior(string name, double health, double armor, int speed, int min, int max) : base(name, health, armor, speed)
        {
            minDamage = min;
            maxDamage = max;
        }

        public void MeleeAttack(Citizen citizen, Random rnd)
        {
            int currentDamage = rnd.Next(minDamage, maxDamage);
            citizen.Wound(currentDamage);
            Console.WriteLine($"{name} attack {citizen.name} with {currentDamage} points of damage");
        }

        public void Attack(Warrior soldier, Random rnd)
        {

        }

        public void Upgrade()
        {
            if(lvl == 0)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }
    }
}
