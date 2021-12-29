using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Auto
    {
        public double weight;
        public double engineVolume;
        public string color;

        protected Auto(double weight, double engineVolume, string color)
        {
            this.weight = weight;
            this.engineVolume = engineVolume;
            this.color = color;
        }

        public void Move()
        {
            Console.WriteLine("is moving");
        }
    }
}
