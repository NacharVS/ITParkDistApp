using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                  //Воин
    class Warrior : BattleUnits
    {
        private bool _rage = false;   /* Ярость война */

        public Warrior(string name) : base(name, 90, 10, "солдат", 5, 2, 8)  /*Конструктор для война*/
        {
        }

        public override double MleeAttack(Random rnd)
        {


            if (Healt > 0.4 * _maxHealth && _rage == false)
            {
                return base.MleeAttack(rnd);
            }
            else
            {
                _rage = true;
                Console.WriteLine($"{name} в ярости");
                return base.MleeAttack(rnd) * 2;
            }
        }
    }
}
