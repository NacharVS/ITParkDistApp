using ConsoleApp1.Strategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class Battle
    {
        public static void Fite(BattleUnit unit1, BattleUnit unit2)
        {
            while(unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.MleeAttack(new Random());
                unit2.Health -= unit1.MleeAttack(new Random());
                unit1.Info();
                unit2.Info();
            }
        }

        public static void Fite(Archer archer, BattleUnit unit2)
        {
            while (archer.Health > 0 && unit2.Health > 0)
            {
                archer.Health -= unit2.MleeAttack(new Random());
                unit2.Health -= archer.RangeAttack(new Random());
                archer.Info();
                unit2.Info();
            }

        }
        public static void Fight(ArcherTower tower, BattleUnit unit2)  /*  Метод боя двух юнитов*/  /*Башня со стрелками и солдат*/
        {

            if (tower.CanAttack)
            {
                //while (tower.Healt > 0 && unit2.Healt > 0)
                //{
                tower.Health = tower.Health - unit2.MleeAttack(new Random());
                unit2.Health -= tower.Attack(new Random());
                tower.Info();
                unit2.Info();
                //}
            }
            else
            {
                tower.Health = tower.Health - unit2.MleeAttack(new Random());
                //unit2.Healt -= tower.Attack(new Random());
                tower.Info();
                unit2.Info();
            }


        }

        public static void Fight(Bildings bilding, BattleUnit unit2)  /*  Метод урона по зданиям*/
        {
            if (unit2.IsCatapult)
            {

                while (bilding.Health > 0)
                {
                    if (bilding.Wall > 0)                                                     /*       Если броня меньше 0*/
                    {
                        bilding.Wall = bilding.Wall - unit2.MleeAttack(new Random());

                        bilding.Info();
                        unit2.Info();
                    }
                    else                                                                       /*  то бьет по здоровью здания*/
                    {
                        bilding.Health = bilding.Health - unit2.MleeAttack(new Random());

                        bilding.Info();
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
