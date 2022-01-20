﻿using System;

namespace ConsoleApp1.Strategy
{
    class BattleUnit : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public bool IsHealthBoosted = false;
        public bool IsFrenzy = false;



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
            if(lvl == 0)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }

        public override void Info()
        {
            Console.WriteLine($"{ name}  {Health } {_maxHealth } { minDamage} {maxDamage} {Armor}");
        }
    }
}
