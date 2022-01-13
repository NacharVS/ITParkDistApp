﻿using System;
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

        public void MleeAttack(MovableUnits peasant, Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            peasant.health -= currentDamage;
            Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
            if (peasant.health <= 0)
                peasant.Termination();

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
    }
}