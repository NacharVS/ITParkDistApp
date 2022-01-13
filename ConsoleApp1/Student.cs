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
        public int _age;
        public static string CollegeName { get { return "KFU"; } }



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
                {
                    Console.WriteLine("Age too small");
                }
                else
                    _age = value;
            } 
        }
        
    }
}
