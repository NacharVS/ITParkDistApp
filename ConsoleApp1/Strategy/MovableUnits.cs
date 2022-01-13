using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        //public string profession; 
        public int speed;
        public int lvl;
        public double slightInjury;
        public double severeInjury;
        public string profession;

        public MovableUnits(string name, double health, double armor, int speed) : base(name, health, armor)
        {
            //profession = professionParam;
            this.speed = speed;
            lvl = 0;
            slightInjury = maxHealth * 30 / 100;
            severeInjury = maxHealth * 10 / 100;
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
            if ((health + healingPowerRange) > 0)
            {
                if ((health + healingPowerRange) < maxHealth && (health + healingPowerRange) > 0)
                {
                    health += healingPowerRange;
                }
                else if ((health + healingPowerRange) > maxHealth)
                {
                    health = maxHealth;
                }

                Console.WriteLine($"{name} - {profession} undergoing treatment");
            }

            else
            {
                health = 0;
                Termination();
            }

            Info();
        }

        public void Move()
        {
            Console.WriteLine($"{name} - is moving with {speed}");
            Info();
        }
    }
}
