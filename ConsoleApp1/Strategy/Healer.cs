using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : Citizen
    {
        private int _medicines;
        private int _healingPowerMin;
        private int _healingPowerMax;

        public Healer(string name) : base(name, 60, 0, 6)
        {
            Profession = "Healer";

            _medicines = 200;
            _healingPowerMin = 3;
            _healingPowerMax = 8;
        }

        public void Treatment(MovableUnits unit, Random rnd)
        {
            if (unit.Health > 0)
            {
                while (unit.Health < unit.MaxHealth)
                {
                    int healingPowerRange = rnd.Next(_healingPowerMin, _healingPowerMax);
                    _medicines -= healingPowerRange;

                    unit.GetTreatment(healingPowerRange);
                }
                unit.Info();
            }
           
            else
            {
                Console.WriteLine($"Healer cannot treat, {unit.Name} - {unit.Profession} is dead!");
            }
            
        }
    }
}
