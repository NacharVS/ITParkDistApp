using System;

namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        private int arrows;
        private double towerDamage;
        public WathingTower(string name) : base(name, 100, 20)
        {
            arrows = 100;
        }
        
        public void Observe()
        {
            Console.WriteLine($"{name} is Observing. Statement {wall}, {health}, {armor}");
        }
        public void Destroyed()
        {
            Console.WriteLine($"{name} is destroyed");
        }
        public void TowerAttack(Soldier soldier)
        {
            
            if (soldier.health > 0)
            {
                if (arrows > 0)
                {
                    towerDamage = 20 - (0.2 * soldier.armor);
                    soldier.health -= towerDamage;
                    Console.WriteLine($"{name} attack {soldier.name} with {towerDamage} points of damage");
                    arrows--;
                    if (soldier.health <= 0)
                        soldier.Termination();

                }
                else
                if(arrows<=0)
                {
                    Console.WriteLine("Arrows is empty");
                }
            }
            else
                if (soldier.health <= 0)
                soldier.Termination();

        }
    
    }
}
