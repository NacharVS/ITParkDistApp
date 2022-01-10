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
        public double slightInjury;
        public double severeInjury;

        public Citizen(string name, double health, double armor, int speed) : base(name, health, armor, speed)
        {
            slightInjury = maxHealth * 30 / 100;
            severeInjury = maxHealth * 5 / 100;
        }

        public void Wound(int currentDamage)
        {
            if ((health - currentDamage) > 0)
            {
                health -= currentDamage;
            }
            else
            {
                health = 0;
                Termination();
            }
            Info();
        }

        public void GetTreatmentHealer(int healingPowerRange)
        {
            if ((health + healingPowerRange) < maxHealth)
            {
                health += healingPowerRange;
            }
            else
            {
                health = maxHealth;
            }

            Console.WriteLine($"{name} - {profession} undergoing treatment");
            Info();
        }
    

        public void GetTreatmentHospital(int healingPowerRange)
        {
            if ((health + healingPowerRange) < maxHealth && (health + healingPowerRange) > 0)
            {
                health += healingPowerRange;
            }
            else if ((health + healingPowerRange) > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health = 0;
                Termination();
            }

            Console.WriteLine($"{name} - {profession} undergoing treatment");
        }
    }
}
