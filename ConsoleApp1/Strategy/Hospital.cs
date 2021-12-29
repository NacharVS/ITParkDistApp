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
        int[] healingPowerRange = new int[3];

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
            for (int i = 0; i < healingPowerMin.Length; i++)
            {
                healingPowerRange[i] = rnd.Next(healingPowerMin[i], healingPowerMax[i]);
            }

            Medicines -= healingPowerRange[0];

            citizen.GetTreatmentHospital(healingPowerRange);
        }
    }
}
