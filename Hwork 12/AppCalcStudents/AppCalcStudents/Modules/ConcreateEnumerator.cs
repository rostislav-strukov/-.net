using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents.Modules
{
    class ConcreateEnumerator : IEnumerator
    {
        private StudentsDiary students;

        private int current = -1;

        public ConcreateEnumerator(StudentsDiary students)
        {
            this.students = students;
        }

        public bool MoveNext()
        {
            if (current < students.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            current = -1;
        }
        public object Current
        {
            get { return students[current];}
        }
    }
}
