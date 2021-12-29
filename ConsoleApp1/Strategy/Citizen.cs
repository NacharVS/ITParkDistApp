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
            health -= currentDamage;
            if (health <= 0) Termination();
        }

        public void GetTreatmentHealer(int healingPowerRange)
        {
            if (health > slightInjury && health < maxHealth)
            {
                if ((health + healingPowerRange) < maxHealth )
                {
                    health += healingPowerRange;
                }
                else
                {
                    health = maxHealth;
                }

                Console.WriteLine($"{name} - {profession} undergoing treatment");
            }

            else if (health < slightInjury)
            {
                Console.WriteLine("Healer cannot treat, needed hospital");
            }
        }

        public void GetTreatmentHospital(int[] healingPowerRange)
        {
            if (health > slightInjury && health < maxHealth)
            {
                GetTreatmentHealer(healingPowerRange[0]);
            }
            else if (health < slightInjury && health > severeInjury)
            {
                health += healingPowerRange[1];
                Console.WriteLine($"{name} - {profession} undergoing treatment");
            }
            else if (health < severeInjury)
            {
                Console.WriteLine($"{name} - {profession} in reanimation");
                if ((health + healingPowerRange[2]) > 0)
                {
                    health += healingPowerRange[2];
                }
                else
                {
                    health = 0;
                    Termination();
                }               
            }
        }
    }
}
