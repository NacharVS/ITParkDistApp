
using ConsoleApp1.Strategy;
using ConsoleApp1.StrategyInterfaces;
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
           
            Console.WriteLine("-------------------------------------StrategyInterface---------------------------------------");
            Archer archer = new Archer(new ShortBow(10), new IronDagger());
            Warrior unit1 = new Warrior();
            unit1.weapon = new StoneAxe();
            unit1.Attack(unit1.weapon.Damage);
            unit1.weapon = new ShortSword();
            unit1.Attack(unit1.weapon.Damage);
            unit1.weapon = new IronDagger();
            unit1.Attack(unit1.weapon.Damage);

        }
    }
}
