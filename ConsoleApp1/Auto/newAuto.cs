using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class newAuto : Auto
    {
        public string mark;
        public string model;
        public string kuzov;

        public newAuto(double weight, double engineVolume, string color,string markParam, string modelParam, string kuzovParam) : base(weight, engineVolume, color)
        {
            mark = markParam;
            model = modelParam;
            kuzov = kuzovParam;
        }
    }
}
