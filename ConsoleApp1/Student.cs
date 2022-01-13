using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string _name;
        private int _age;
        private static string _colledgeName = "It Academy";

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - _age;
            }
            set
            {
                if (value < 18)
                    Console.WriteLine("Age too small");
                else _age = value;
            }
        }
        public static string ColledgeName { get => _colledgeName; set => _colledgeName = value; }
        //public void Studing()
        //{
        //    Console.WriteLine($"Student {name} is studing in {colledgeName}");
        //}
    }
}
