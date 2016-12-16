using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classss.Pupils;

namespace Classss
{
    class ClassRoom
    {
        //Pupil pupil = null;
        //Pupil exelent = null;
        //Pupil good = null;
        //Pupil bad = null;

        public ClassRoom() { }

        public ClassRoom(Pupil exelent, Pupil good, Pupil bad, Pupil pupil)
        {
            pupil = new Pupil();
            exelent = new ExelentPupil();
            good = new GoodPupil();
            bad = new BadPupil();

            pupil.Study();
            exelent.Study();
            good.Study();
        }       
    }
}
