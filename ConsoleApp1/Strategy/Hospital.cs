using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        int firstAidMedicines;
        int medicalEquipment;
        int healingPowerMin;
        int healingPowerMax;

        public Hospital(string name, int health, int armor) : base(name, health, armor)
        {
            firstAidMedicines = 1000;
            medicalEquipment = 1000;
            healingPowerMin = 20;
            healingPowerMax = 40;
        }

        public void Treatment(Citizen citizen, Random rnd)
        {
            int healingPowerRange1 = rnd.Next(healingPowerMin, healingPowerMax);
            int healingPowerRange2 = rnd.Next(healingPowerMin/5, healingPowerMax/5);

        }
    }
}
