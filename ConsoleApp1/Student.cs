using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public int age;
        public string colledgeName;

        public void Studing()
        {
            Console.WriteLine($"Student {name} is studing in {colledgeName}");
        }
    }
}
