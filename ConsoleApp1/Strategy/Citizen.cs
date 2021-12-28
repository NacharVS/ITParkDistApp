using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Citizen : MovableUnits
    {
        public string profession;

        public Citizen(string name, double health, double armor, int speed) : base(name, health, armor, speed)
        {

        }

        public void Wound(int currentDamage)
        {
            health -= currentDamage;
            if (health <= 0) Termination();
        }

        public void GetTreatmentHealer(int healingPowerRange)
        {
            if (health > 30)
            {
                health += healingPowerRange;
                Console.WriteLine($"{name} - {profession} undergoing treatment");
            }
            else if (health < 30)
            {
                Console.WriteLine("Healer cannot treat, needed hospital");
            }
        }

        public void GetTreatmentHospital(int healingPowerRange1, int healingPowerRange2)
        {
            if (health > 30)
            {
                health += healingPowerRange1;
            }
            else if (health < 30 && health > 5)
            {
                health += healingPowerRange2;
            }
        }
    }
}
