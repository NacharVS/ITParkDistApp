using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
              //Солдат
    class BattleUnits : MovableUnits
    {
        public int minDamage;     /*Параметр показания урона */ /*минимальный урон*/
        public int maxDamage;                                   /*максимальный урон*/

        public BattleUnits(string name, int healt, int armor, string profissionParam, int speedParam, int min, int max) : base(name, healt, armor, profissionParam, speedParam)
        {
            minDamage = min;
            maxDamage = max;
        }

        public virtual double MleeAttack(Random rnd)   /*Рукопашная атака*/
        {

            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;




        }

        public void Attack(BattleUnits solder, Random rnd)     /*Метод атаки на Soldie(Солдата)*/
        {

        }

        public void Upgrade()           /*Метод улучшения*/
        {
            if (lxl == 0)
            {
                minDamage += 1;           /*Улутшает минимальнй и максимальный урон после каждой атаки*/
                maxDamage += 2;
                lxl++;
            }
        }
    }
}
