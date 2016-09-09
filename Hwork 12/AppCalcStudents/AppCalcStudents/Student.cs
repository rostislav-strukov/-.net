using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using System.Xml.Serialization;

namespace AppCalcStudents
{
    public class Student
    {
        private string _name;
        private uint _age;
        private string _subjectNew;
        private uint _rate;

        [XmlAttribute("SerialNAME")]
        public string Name { get { return _name; } set { _name = value; } }
        [XmlAttribute("SerialAGE")]
        public uint Age { get { return _age; } set { _age = value; } }
        [XmlAttribute("SerialID")]
        public string SubjectNew { get { return _subjectNew; } set { _subjectNew = value; } }
        [XmlAttribute("SerialVALUE")]
        public uint Rate { get { return _rate; } set { _rate = value; } }
        [XmlArray("Students"), XmlArrayItem(typeof(StudentsDiary), ElementName = "Student")]
        public StudentsDiary students { get; set; }


        public Student(string _nameArg, uint _ageArg, string _subjectNewArg, uint _rateArg)
        {
            Name = _nameArg;
            Age = _ageArg;
            SubjectNew = _subjectNewArg;
            Rate = _rateArg;

        }

        public Student() { }
    }
}
