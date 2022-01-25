using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class BattleUnit : MovadelUnits   //Сражающиеся юниты
    {
        public int minDamage; //мин урон который может нанести 
        public int maxDamage; //мак урон который может нанести

        public BattleUnit(string name, int health, int armor, int speedParam, string professionParam, int min, int max) : base(name, health, armor, speedParam, professionParam)
        {
            minDamage = min;
            maxDamage = max;
        }

        public double MleeAttack(Random rnd) //аттака крестьянина
        {
            
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;

            //unit.health -= currentDamage;
            //Console.WriteLine($"{name} attack, {unit.name} with, {currentDamage} point damage");
            //if (unit.health <= 0)
            //{
            //    unit.Termination();
            //}
            
        }
      

        

    }
}
