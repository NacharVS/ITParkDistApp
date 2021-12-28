using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class Healer: BattleUnit
    {
        public int minHealer;
        public int maxHealer;

        public Healer(string name) : base(name, 50, 0, "Healer", 6, 1, 3)
        {

            minHealer = 2;
            maxHealer = 5;
            
        }
        public void Healing(Soldier soldier, Random rnd)
        {
            while (soldier.health<60)
            {
                double cure = Convert.ToDouble(rnd.Next(minHealer, maxHealer));
                soldier.health += cure;
                Console.WriteLine($"{name} improved health {soldier.name} by {cure} units");
                
                if (soldier.health >= 60)
            {
                Console.WriteLine("The patient was cured");
                    break;
            }
            }
        }
        public void Healing(Peasant peasant, Random rnd)   
        {
            while (peasant.health < 30)
            {
                double cure = Convert.ToDouble(rnd.Next(minHealer, maxHealer));
                peasant.health += cure;
                Console.WriteLine($"{name} improved health {peasant.name} by {cure} units ");

                if (peasant.health >= 30)
                {
                    Console.WriteLine("The patient was cured");
                    break;
                }
            }
        }

        public void Healing(Archer archer, Random rnd)
        {
            while (archer.health < 45)
            {
                double cure = Convert.ToDouble(rnd.Next(minHealer, maxHealer));
                archer.health += cure;
                Console.WriteLine($"{name} improved health {archer.name} by {cure} units ");

                if (archer.health >= 45)
                {
                    Console.WriteLine("The patient was cured");
                }
            }
        }


        public void Healing(Healer healer, Random rnd)
        {
            while (healer.health < 50)
            {
                double cure = Convert.ToDouble(rnd.Next(minHealer, maxHealer));
                healer.health += cure;
                Console.WriteLine($"{name} improved his health by {cure} units ");

                if (healer.health >= 50)
                {
                    Console.WriteLine("The patient was cured");
                }
            }
        }

    }
}
