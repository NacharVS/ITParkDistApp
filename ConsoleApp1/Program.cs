using System;
using System.Collections.Generic;
using System.Threading;
using ConsoleApp1.Mylib;
using ConsoleApp1.Strategy;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //WathingTower wathingTower = new WathingTower("WathingTower");
            //Catapult catapult = new Catapult();

            //ArcherTower archerTower = new ArcherTower();

            //Healer healer = new Healer("Gendalf");

            Warrior warrior1 = new Warrior("Bob1");
            Warrior warrior2 = new Warrior("Bob2");

            Shaman shaman = new Shaman("Gendalf");

            //shaman.StoneSkin(warrior1);
            //shaman.Frenzy(warrior2);

            //Archer archer1 = new Archer("Legolaz1");
            //Archer archer2 = new Archer("Legolaz2");
            //healer.SalvationBuff(warrior1);
            //healer.SalvationBuff(warrior1);

            warrior1.MaxHealthChangedEvent += (string name, double health, double damagecount) =>
            {
                Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
            }; 


            

            shaman.BoostHealth(warrior1);

            Battle.Fight(warrior1, warrior2);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(warrior2, rnd);

            //Battle.Fight(archer1, archer2);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(archer2, rnd);

            //Battle.Fight(archer1, warrior1);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(warrior1, rnd);

            //Battle.Fight(archer2, warrior2);
            //healer1.Treatment(archer2, rnd);
            //healer1.Treatment(warrior2, rnd);

            //Battle.BuildingAttack(wathingTower, catapult);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(warrior1, rnd);

            //Battle.Fight(warrior1, catapult);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);

            //Battle.MovingAttack(catapult, warrior1);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);

            //Battle.Fight(archerTower, warrior1);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);

            void Message()
            {
                Console.WriteLine($"Health has changed.");
            }

            void MessageMaxHealth(string name, double diff)
            {
                Console.WriteLine($"{name} - MaxHealth has changed to {diff}.");
            }



            // Реализовать новый юнит Shaman которыйможет накидывать ряд усилений. 
            // 1. BoostHealth - Увеличивает максимальное здоровье на 50%
            // 2. Frenzy - Увеличивает показатель урона на 1,5 и снижает показатель защиты 0.5
            // 3. StoneSkin - увеличивает показатель защиты в 2 раза, и снижает скорость в 2 раза
            // *все усиления могут накладывать только 1 раз на 1 юнита (не стакаються)

        }


    }
}
