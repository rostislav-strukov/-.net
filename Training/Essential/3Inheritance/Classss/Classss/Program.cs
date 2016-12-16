using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classss.Pupils;

namespace Classss
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil();
            Pupil exelent = new Pupil();
            Pupil good = new Pupil();
            Pupil bad = new Pupil();

            ClassRoom classroom = new ClassRoom(exelent, good, bad, pupil);

        }
    }
}
