using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        int medicines;

        int[] healingPowerMin = new int[3];
        int[] healingPowerMax = new int[3];
        int healingPowerRange;

        public Hospital(string name) : base(name, 2000, 300)
        {
            medicines = 1000;
            
            healingPowerMin[0] = 20;
            healingPowerMax[0] = 40;

            healingPowerMin[1] = 5;
            healingPowerMax[1] = 10;

            healingPowerMin[2] = -5;
            healingPowerMax[2] = 10;
        }

        public void Treatment(MovableUnits unit, Random rnd)
        {
            while ((unit.health < unit.maxHealth) && (unit.health > 0))
            {
                if ((unit.health > unit.slightInjury) && (unit.health < unit.maxHealth))
                {
                    healingPowerRange = rnd.Next(healingPowerMin[0], healingPowerMax[0]);
                }
                else if ((unit.health <= unit.slightInjury) && (unit.health > unit.severeInjury))
                {
                    healingPowerRange = rnd.Next(healingPowerMin[1], healingPowerMax[1]);
                }
                else if ((unit.health <= unit.severeInjury) && (unit.health > 0))
                {
                    healingPowerRange = rnd.Next(healingPowerMin[2], healingPowerMax[2]);
                }
                medicines -= healingPowerRange;
                unit.GetTreatmentHospital(healingPowerRange);
                healingPowerRange = 0;
            }

            if (unit.health <= 0)
            {
                Console.WriteLine($"Hospital cannot treat, {unit.name} is dead!");
            }
        }

        public new void Info()
        {
            Console.WriteLine($"Name:{name}/ Health:{health}/ armor:{armor}/ medicines:{medicines}");
        }
    }
}
