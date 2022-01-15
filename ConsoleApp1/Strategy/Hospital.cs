using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        private int _medicines;
        private int _healingPowerMin;
        private int _healingPowerMax;

        public Hospital() : base("Hospital", 2000, 300)
        {
            _medicines = 1000;
            _healingPowerMin = 10;
            _healingPowerMax = 30;
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
            }

            else
            {
                Console.WriteLine($"Healer cannot treat, {unit.Name} - {unit.Profession} is dead!");
            }
        }

        public new void Info()
        {
            Console.WriteLine($"Name:{Name}/ Health:{Health}/ armor:{Armor}/ medicines:{_medicines}");
        }
    }
}
