using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents
{
    class Student
    {
        private string _name;
        private uint _age;

        public string Name { get { return _name; } set { _name = value; } }
        public uint Age { get { return _age; } set { _age = value; } }
    }
}
