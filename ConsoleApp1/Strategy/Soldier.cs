using System;

namespace ConsoleApp1.Strategy
{
    class Soldier : MovableUnits
    {
        public int minDamage;
        public int maxDamage;
        public Soldier(string name) : base(name, 60, 5, "Soldier", 5)
        {
            minDamage = 2;
            maxDamage = 7;
        }
        public void AttackPeasant()
        {
            Random rnd = new Random();
            currentDamage = Convert.ToDouble((rnd.Next(minDamage, maxDamage)));
            //double currentDamage= new Random().Next(minDamage, maxDamage + 1) - Peasant.armor * 0.1;
            peasant.health -= currentDamage;
            Console.WriteLine($"{name} attack {Peasant.name} with {currentDamage} ");
            if (Peasant.health <= 0)
                Peasant.Termination();
            Console.WriteLine();
        }
        public void AttackSoldier()
        {

        }
        public void Upgrade()
        {
            if(lvl==1)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }
    }
}
