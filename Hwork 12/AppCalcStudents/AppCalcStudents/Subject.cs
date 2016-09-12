using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents
{
    public class Subject
    {
        private string _subjectNew;
        private uint _rate;

        public string SubjectNew { get { return _subjectNew; } set { _subjectNew = value; } }
        public uint Rate { get { return _rate; } set { _rate = value; } }
    }
}
