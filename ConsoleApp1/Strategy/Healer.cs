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
            profession = "Healer";
        }

        public void Treatment(MovableUnits unit, Random rnd)
        {
            if (unit.health > unit.slightInjury)
            {
                while (unit.health < unit.maxHealth)
                {
                    int healingPowerRange = rnd.Next(healingPowerMin, healingPowerMax);

                    medicines -= healingPowerRange;

                    unit.GetTreatmentHealer(healingPowerRange);
                }
            }

            else if (unit.health < unit.slightInjury && unit.health > 0)
            {
                Console.WriteLine("Healer cannot treat, needed hospital");
            }

            else
            {
                Console.WriteLine($"Healer cannot treat, {unit.name} is dead!");
            }
        }
    }
}
