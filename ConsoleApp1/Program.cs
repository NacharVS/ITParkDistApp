using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------
            //Стратегия

            Random rnd = new Random();
            Peasant peasant1 = new Peasant("Ivan"); /*Создание экземпляра */
            Healer healer = new Healer("Gendalf", 20);
            Archer archer = new Archer("Legolas");



            /*peasant1.Work(); */  /*вызов метода(Move или Work)*/
            /*tower1.Observe();*/   /*Вызов метода Observe(Наблюдать)*/

            //peasant1.Move();

            //archer.RangeAttack(healer, rnd);
            //healer.Info();
            //archer.RangeAttack(healer, rnd);
            //healer.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();

            //healer.Heal(peasant1);
            //peasant1.Move();

            Console.WriteLine("--------------------Бой 2х солдат---------------------------------------------");

            Warrior war1 = new Warrior("Bob");   /*Создание солдата*/
            Warrior war2 = new Warrior("John");
            //war1.DamageEvent += Damage;
            //war1.HealEvent += Heal;

            /*Battle.Fight(war1, war2);*/  /*стрелок атакует солдата*/


            Console.WriteLine("---------------------Бой  башни с лучниками и солдата--------------------------");

            //ArcherTower archerTower1 = new ArcherTower();
            //Console.WriteLine($"{archerTower1.name} атаковал {war1.name}a");
            //for (int i = 0; i <= 1; i++)
            //{
            //    archerTower1.LoadArchers(archer);
            //}
            //Battle.Fight(archerTower1, war1);
            Console.WriteLine("-------------------------Бой между башнями  и солдата--------------------------------");

            /*WathingTower wTower = new WathingTower();*/  /*Создание водонапорной башни*/
            //wTower.Observe();
            //Battle.Fight(wTower, war1);
            //wTower.Info();
            Console.WriteLine("-------------------------------Катапульта--------------------------------------------");
            //Catapult catapult1 = new Catapult();
            //catapult1.Info();
            //Battle.Fight(wTower, catapult1);
            Console.WriteLine("-----------------------------------Шаман---------------------------------------------");
            //Shaman shaman1 = new Shaman("Peter");
            //shaman1.HeathBuff(war1);
            //war1.Info();
            //shaman1.FrenzyBuff(war1);
            //war1.Info();
            Console.WriteLine("---------------------------------СПАСEНИЕ---------------------------------------------");
            //Battle.Fight(archer,war1);
            //healer.SalvationBuff(war1);
            //shaman1.FrenzyBuff(war2);
            Console.WriteLine("------------------------------------Делегаты--------------------------------------------");
            //war1.HealthChangedEvent += Message;
            //Battle.Fight(war1,war2);
            Console.WriteLine("------------------------------------Анонимный метод ------------------------------------");

            //Анонимный метод


            //war1.DamageEvent += (string name, double health, double damagecount) =>
            //{
            //      Console.WriteLine($"{name} with {healer} HP.Injured bu {damagecount}");
            //};
            //war1.MaxHealthEvent += (string name, double diff) =>
            //{
            //    Console.WriteLine($"Health of {name} increased by {diff}");
            //};
            //shaman1.HeathBuff(war1);
            //Console.WriteLine("-------------------------------ID---------------------------------------------------------");
            //Summ<int>(5, 9);
            //Summ<string>("545454","46464646");
            //Summ<Warrior>(war1, war2);
            Console.WriteLine("-------------------------------------InterfaceLab-------------------------------------------------------------");

        }
    }
}
