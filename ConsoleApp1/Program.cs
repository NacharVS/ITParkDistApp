using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ConsoleApp1.InterfacesLab;
using ConsoleApp1.StrategyInterfaces;
using ConsoleApp1.StrategyNew;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лекция 14. 01.02.2022

            var Bob = new Machinegun();
            Bob.

            //Лекиця 30/01/2022
            //Archer archer = new Archer(new ShortBow(10), new ShortSword());
            //for (int i = 0; i < 20; i++)
            //{
            //    archer.Attack();
            //}
            //Warrior unit1 = new Warrior();
            //unit1.weapon = new StoneAxe();
            //unit1.Attack(unit1.weapon.Damage);
            //unit1.weapon = new ShortSword();
            //unit1.Attack(unit1.weapon.Damage);
            //unit1.weapon = new IronDagger();
            //unit1.Attack(unit1.weapon.Damage);
            //weapon2.Shoot();
            //weapon3.Shoot();

            //var rnd = new Random();
            //Peasant peasant1 = new Peasant("Ivan");
            //var archer = new Archer("Rifleman", 535,0);
            //var healer = new Healer("Priest",290,200,0);
            //var shaman = new Shaman("Shaman", 335, 200, 0);
            //var war1 = new Warrior("Footman", 420, 2,12,13);
            //var war2 = new Warrior("Knight", 835,5,30,38);
            //war1.DamageEvent += (string name, double health, double damagecount) =>
            //{
            //    Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
            //}; //реализация анонимного метода через лямбда-выражение

            //war1.MaxHealthEvent += (string name, double diff) =>
            //{
            //    Console.WriteLine($"Health of {name} increased by {diff}");
            //};
            // war1.HealEvent += Heal;

            //Battle.Fight(archer, war2);

            //var catapult = new Catapult("Catapult",700,45,55);
            //var building= new Buildings("Town Hall",1500,5);
            //Battle.Fight(catapult, building, rnd);
            //shaman.HealthBoost(war1);
            //shaman.Frenzy(war1);
            //war1.FrenzyEvent += Frenzy;

            ////Console.WriteLine(Peasant._id);
            ////Console.WriteLine((int)war1._id+8);

            //Summ<int>(5, 9);
            //Summ<string>("456", "789");
            //Summ<Warrior>(war1, war2);
            //shaman.HealthBoost(catapult);
            //shaman.HealthBoost(war2);
            //healer.Heal(war1);
            //Battle.Fight(catapult, war2, rnd);
            //Battle.Fight(war1,war2, rnd);
            //healer.Heal(war1);
            //shaman.StoneSkin(war1);
            //Battle.Fight(catapult, war2);
            //Battle.Fight(catapult, archer);
            //Battle.Fight(catapult, healer);
            //ArcherTower archerTower1 = new ArcherTower("Guard Tower",500,5, 20, 30);
            //Console.Write("How many archers in a ArchTower?(0-5):");
            //int archAmount = Convert.ToInt32(Console.ReadLine());
            //Battle.Fight(archerTower1, archAmount, catapult);
            //healer.Heal(war1);
            //war1.Info();
            //healer.Heal(catapult);
            //catapult.Info();
            //healer.Heal(war1);
            //war1.Info();
            //healer.Heal(catapult);
            //catapult.Info();
            //Battle.Fight(catapult, war1);
            //13.01.2022 Инкапсуляция свойств. Лекция 9
            //var std1 = new Student();
            //std1.Age = 20;
            //Console.WriteLine(std1.Age);
            //Lection 16.01.22
            //for (int i = 0; i < 5; i++)
            //{
            //    archerTower1.LoadArchers(archer);
            //}
            //Battle.Fight(archerTower1, war1);
            //Console.Read();
            //ДЗ 13.01.2022
            //1) доработать методы боя с учетом показателя брони (формулу на свое усмотрение).
            //2) нового юнита добавим Catapult - ломает здания. Реализовать атаку.
            //3*) реализовать атаку катапультой по МуваблЮнит(движущимся) и зданиям
            //4**)Сделать АрчерТовер, наследуется от ВатчингТовер. Доработать, чтобы в башне могло быть до 5 лучников - 
            //-чем больше лучником - тем больше урон. Без лучников не атакует.

            //новый юнит - накидывает бафы на юнитов
            //1.Boost.Health - увеличивает здовроьве на 50%
            //2.Frenzy - увеличивает показатель урона в 1.5 и снижает защиту на 0,5
            //3.StoneSkin - увеличивает защиту в 2 раза и снижает скорость в 2 раза
            //*все усиления могут накладываться 1 раз

        }
        public static void Frenzy(string name,int armor, double minDamage, double maxDamage)
        {
            Console.WriteLine($"{name} casts Frenzy arm:{armor}, mnDmg:{minDamage}, mxDmg:{maxDamage}");
        }
        public static void Summ<T>(T a, T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
