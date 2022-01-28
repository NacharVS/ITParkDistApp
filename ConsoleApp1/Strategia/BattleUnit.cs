using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
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

        public virtual double MleeAttack(Random rnd) //аттака крестьянина
        {
            
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;

        }
        public void Attack(BattleUnit solder, Random rnd)     /*Метод атаки на Soldie(Солдата)*/
        {

        }

        public void Upgrade()           /*Метод улучшения*/
        {
            if (lvl == 0)
            {
                minDamage += 1;           /*Улутшает минимальнй и максимальный урон после каждой атаки*/
                maxDamage += 2;
                lvl++;
            }
        }





    }
}
