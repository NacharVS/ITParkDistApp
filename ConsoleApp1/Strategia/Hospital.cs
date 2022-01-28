using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class Hospital : MovadelUnits
    {
        public Hospital(string name, double healAmountParam) : base(name, 70, 50, 0, "Hospital")
        {
        }
    }
}
