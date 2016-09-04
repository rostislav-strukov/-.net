using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents
{
    class Subject
    {
        private string _subjectNew;
        private uint _rate;

        public string SubjectNew { get { return _subjectNew; } set { _subjectNew = value; } }
        public uint Age { get { return _rate; } set { _rate = value; } }
    }
}
