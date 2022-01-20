using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class Shaman : Unit

    {
        public Shaman(string name, int health, int armor) : base(name, health, armor)
        {
        }
        public double BoostHealth (BattleUnit unit)
        {
            unit._maxHealth += 0.5*unit.Health ;
            Console.WriteLine($"Health {unit.name} increased by 50%. Health = {unit._maxHealth}");
            return unit._maxHealth;
            
        }
        public double BoostHealth (MovableUnits unit)
        {
            unit._maxHealth += 0.5 * unit.Health;
            Console.WriteLine($"Health {unit.name} increased by 50%. Health = {unit._maxHealth}");
            return unit._maxHealth;
        }

        public double Frenzy (BattleUnit unit, Random rnd)
        {
            double currentDamage =Convert.ToDouble(rnd.Next(unit.minDamage, unit.maxDamage));
            currentDamage *=  1.5;
            Console.WriteLine($"Current damage {unit.name} increased in 1.5 times = {currentDamage}");
            
            unit.Armor /= 0.5;
            Console.WriteLine($"Armor increased  {unit.name} in 0.5 times = {unit.Armor}");
            return currentDamage;
        }

        public double StoneSkin(MovableUnits unit)
        {
            unit.Armor *= 2;
            Console.WriteLine($"Armor increased  {unit.name} in 2 times = {unit.Armor}");
            unit.speed /= 2;
            Console.WriteLine($"Speed {unit.name} reduced by 2 times. Speed = {unit.speed} ");
            return unit.Armor;
        }

        public double StoneSkin(BattleUnit unit)
        {
            unit.Armor *=  2;
            Console.WriteLine($"Armor increased  {unit.name} in 2 times = {unit.Armor}");
            unit.speed /=  2;
            Console.WriteLine($"Speed {unit.name} reduced by 2 times. Speed = {unit.speed} ");
            return unit.Armor;
        }

        //public double Frenzy увеличивает показатель урона на 1.5 и
        //снижает показатель защиты на 0.5;
        //public double StoneSkin увеличивает показатель защтьы в 2 раза,
        //снижает скорость в два раза;
        //все только один раз, боьше не могут увеличить


    }
}
