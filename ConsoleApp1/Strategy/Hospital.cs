using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        private double healing;
        private int medicament;
        public Hospital (string name) : base("Hospital", 35, 0)
        {
            medicament = 200;
        }
        public void HospitalHealing(Peasant peasant)
        {
            if (medicament > 0)
            {
                healing = 15;
                if ((0 < peasant.health )&&(30>peasant.health))
                {
                    medicament -= 15;
                    peasant.health += healing;
                    Console.WriteLine($"{name} heals {peasant.name} by {healing} hp.{name} has {medicament} medicaments");
                }
                else
                if (peasant.health <= 0)
                {
                    Console.WriteLine($"{peasant.name} is death.");
                }
                else
                    if (peasant.health >= 30)
                {
                    Console.WriteLine($"{peasant.name} has max health.");
                }
            }
            else
                if (medicament <= 0)
            {
                Console.WriteLine($"{name} don't have medicament.");
            }
        }
    }
}
