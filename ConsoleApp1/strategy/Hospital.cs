using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class Hospital : Buildings
    {//людей лечить
        double treatment;
        public Hospital(string name) : base("Hospital", 100, 20)
        {
            treatment = 7;
        }

        public void Treatment(Soldier soldier)
        {
            while (soldier.health < 60)
            {
                soldier.health += treatment;
                Console.WriteLine($"Treatment in the hospital {soldier.name} has added 7 units of health");

                if (soldier.health >= 60)
                {
                    Console.WriteLine("The patient is healthy");
                    break;
                }
            }
        }
        public void Treatment(Archer archer)   
        {
            while (archer.health < 45)
            {
                archer.health += treatment;
                Console.WriteLine($"Treatment in the hospital {archer.name} has added 7 units of health");

                if (archer.health >= 45)
                {
                    Console.WriteLine("The patient is healthy");
                    break;
                }
            }
        }
        public void Treatment(Peasant peasant)
        {
            while (peasant.health < 30)
            {
                peasant.health += treatment;
                Console.WriteLine($"Treatment in the hospital {peasant.name} has added 7 units of health");

                if (peasant.health >= 30)
                {
                    Console.WriteLine("The patient is healthy");
                    break;
                }
            }
           
        }
        public void Treatment(Healer healer)
        {
            while (healer.health < 50)
            {
                healer.health += treatment;
                Console.WriteLine($"Treatment in the hospital {healer.name} has added 7 units of health");

                if (healer.health >= 50)
                {
                    Console.WriteLine("The patient is healthy");
                    break;
                }
            }
        }
    }
}
