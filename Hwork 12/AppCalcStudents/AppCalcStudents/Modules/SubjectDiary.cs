using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using AppCalcStudents;

namespace AppCalcStudents.Modules
{
    class SubjectDiary : IEnumerable
    {
        Dictionary<String, Int32> subjects = new Dictionary<string, int>();

        Subject subject = new Subject();

        public static Dictionary<String, Int32> CreateSubject()
        {

        }

        //public StudentsDiary this[int index]
        //{
        //    get { return studentsDiary[index]; }
        //    set { students.Insert(index, value); }
        //}

        //public int Count
        //{
        //    get { return students.Count; }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    return new ConcreateEnumerator(this);
        //}
    }
}
