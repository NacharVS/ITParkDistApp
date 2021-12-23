using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto
    {
        public string Mark;
        public string Model;
        public double Price;
        public int YearOfRelease;

        public Auto(string mark, string model, double price, int yearOfRelease)
        {
            Mark = mark;
            Model = model;
            Price = price;
            YearOfRelease = yearOfRelease;
        }


        // создать список автомобилей, и осуществить подбор по году выпуска, по цене и по марке. 
    }
}
