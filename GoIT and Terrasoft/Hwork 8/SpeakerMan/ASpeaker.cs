using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerMan
{
    abstract class ASpeaker
    {
        private string _name;

        abstract public string Name { get; set; }

        abstract public void GetAnswer();
        abstract public void Goodbye();
        abstract public void GetHello();
        abstract public void GetCollor();
        abstract public void GetYouName();
        abstract public void GetHowAreYou();
    }
}
