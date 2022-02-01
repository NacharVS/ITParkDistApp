
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

           IBattleUnit archer = new Archer(new ShortBow(10), new ShortSword());
            for (int i = 0; i < 20; i++)
            {
                archer.Attack();
            }
      

        }
    }
}
