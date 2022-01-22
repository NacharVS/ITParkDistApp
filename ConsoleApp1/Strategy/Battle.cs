using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
              //Атака одного юнита на другого(БОЙ)
    class Battle
    {
        public static void Fight(BattleUnits unit1, BattleUnits unit2)  /*  Метод боя двух юнитов*/   /*2 солдата*/
        {
            while (unit1.Healt > 0 && unit2.Healt > 0)
            {
                unit1.Healt -= unit2.MleeAttack(new Random());
                unit2.Healt -= unit1.MleeAttack(new Random());
                unit1.Info();
                unit2.Info();
            }
        }

        public static void Fight(Archer archer, BattleUnits unit2)  /*  Метод боя двух юнитов*/  /*Стрелок и солдат*/
        {
            while (archer.Healt > 0 && unit2.Healt > 0)
            {
                archer.Healt = archer.Healt - unit2.MleeAttack(new Random());
                unit2.Healt -= archer.RangeAttack(new Random());
                archer.Info();
                unit2.Info();
            }
        }
        public static void Fight(ArcherTower tower, BattleUnits unit2)  /*  Метод боя двух юнитов*/  /*Башня со стрелками и солдат*/
        {

            if (tower.CanAttack)
            {
                //while (tower.Healt > 0 && unit2.Healt > 0)
                //{
                tower.Healt = tower.Healt - unit2.MleeAttack(new Random());
                unit2.Healt -= tower.Attack(new Random());
                tower.Info();
                unit2.Info();
                //}
            }
            else
            {
                tower.Healt = tower.Healt - unit2.MleeAttack(new Random());
                //unit2.Healt -= tower.Attack(new Random());
                tower.Info();
                unit2.Info();
            }


        }

        public static void Fight(Buildings building, BattleUnits unit2)  /*  Метод урона по зданиям*/
        {
            if (unit2.IsCatapult)
            {

                while (building.Healt > 0)
                {
                    if (building.Wall > 0)                                                     /*       Если броня меньше 0*/
                    {
                        building.Wall = building.Wall - unit2.MleeAttack(new Random());

                        building.Info();
                        unit2.Info();
                    }
                    else                                                                       /*  то бьет по здоровью здания*/
                    {
                        building.Healt = building.Healt - unit2.MleeAttack(new Random());

                        building.Info();
                        unit2.Info();

                    }
                }

            }
            else
            {
                Console.WriteLine($"{unit2.name} не может оттаковать здание");
            }

        }
    }
}
