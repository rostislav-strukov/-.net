using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents.Modules
{
    class ConcreateEnumerator : IEnumerator
    {
        private ConcreateEnumerable enumerable;
        private int current = -1;

        public ConcreateEnumerator(ConcreateEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        public bool MoveNext()
        {
            if (current < enumerable.Count - 1)
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
            get { return enumerable[current];}
        }
    }
}
