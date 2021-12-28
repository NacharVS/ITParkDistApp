using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : Citizen
    {
        int firstAidMedicines;
        int healingPowerMin;
        int healingPowerMax;
;
        public Healer(string name, double health, double armor, int speed) : base(name, health, armor, speed)
        {
            firstAidMedicines = 200;
            healingPowerMin = 3;
            healingPowerMax = 8;
        }
    }
}
