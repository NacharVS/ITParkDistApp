using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        int Medicines;

        int[] healingPowerMin = new int[3];
        int[] healingPowerMax = new int[3];
        int healingPowerRange;

        public Hospital(string name, int health, int armor) : base(name, health, armor)
        {
            Medicines = 1000;
            
            healingPowerMin[0] = 20;
            healingPowerMax[0] = 40;

            healingPowerMin[1] = 5;
            healingPowerMax[1] = 10;

            healingPowerMin[2] = -5;
            healingPowerMax[2] = 10;
        }

        public void Treatment(Citizen citizen, Random rnd)
        {
            while (citizen.health < citizen.maxHealth || citizen.health == 0)
            {
                if (citizen.health > citizen.slightInjury && citizen.health < citizen.maxHealth)
                {
                    healingPowerRange = rnd.Next(healingPowerMin[0], healingPowerMax[0]);
                    //citizen.GetTreatmentHealer(healingPowerRange[0]);
                }
                else if (citizen.health < citizen.slightInjury && citizen.health > citizen.severeInjury)
                {
                    healingPowerRange = rnd.Next(healingPowerMin[1], healingPowerMax[1]);
                }
                else if (citizen.health < citizen.severeInjury && citizen.health > 0)
                {
                    healingPowerRange = rnd.Next(healingPowerMin[2], healingPowerMax[2]);
                }
                else
                {
                    Console.WriteLine($"Hospital cannot treat, {citizen.name} is dead!");
                }

                Medicines -= healingPowerRange;
                citizen.GetTreatmentHospital(healingPowerRange);
            }
        }
    }
}
