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
        private string _colledgeName;

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
                return _age;
            }
            set
            {

                _age = value;
            }
        }

        public string ColledgeName
        {
            get
            {
                return _colledgeName;
            }
            set
            {
                _colledgeName = value;
            }
        }
    }
}
