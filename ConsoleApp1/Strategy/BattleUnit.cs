using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class BattleUnit : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public BattleUnit(string name, int health, int armor, string professionParam, int speedParam, int min, int max) : base(name, health, armor, professionParam, speedParam)
        {
            minDamage = min;
            maxDamage = max;
        }

        public virtual double MleeAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;

        }

        public void Attack(BattleUnit soldier, Random rnd)
        {

        }

        public void Upgrade()
        {
            if (lvl == 0)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }

        


        //public void MleeAttack(MovableUnits peasant, Random rnd)
        //{
        //    double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
        //    peasant.health -= currentDamage;
        //    Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
        //    if (peasant.health <= 0)
        //        peasant.Termination();

        //}

        //public void Attack(BattleUnit soldier, Random rnd)
        //{
        //    double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
        //    soldier.health -= currentDamage;

        //    double currentDamage1 = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
        //    this.health -= currentDamage1;

        //    Console.WriteLine($"{name} attack {soldier.name} with {currentDamage} points of damage");
        //    if (soldier.health <= 0)
        //        soldier.Termination();

        //    Console.WriteLine($"{soldier.name} attack {name} with {currentDamage1} points of damage");
        //    if (this.health <= 0)
        //        this.Termination();
        //}

        
    }
}