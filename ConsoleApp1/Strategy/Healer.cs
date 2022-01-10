using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : Citizen
    {
        int medicines;
        int healingPowerMin;
        int healingPowerMax;

        public Healer(string name) : base(name, 60, 0, 6)
        {
            medicines = 200;
            healingPowerMin = 3;
            healingPowerMax = 8;
        }

        public void Treatment(Citizen citizen, Random rnd)
        {
            if (citizen.health > citizen.slightInjury)
            {
                while (citizen.health < citizen.maxHealth)
                {
                    int healingPowerRange = rnd.Next(healingPowerMin, healingPowerMax);

                    medicines -= healingPowerRange;

                    citizen.GetTreatmentHealer(healingPowerRange);
                }
            }

            else if (citizen.health < citizen.slightInjury && citizen.health > 0)
            {
                Console.WriteLine("Healer cannot treat, needed hospital");
            }

            else
            {
                Console.WriteLine($"Healer cannot treat, {citizen.name} is dead!");
            }
        }
    }
}
