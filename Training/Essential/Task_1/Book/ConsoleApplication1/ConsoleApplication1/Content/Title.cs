using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Content
{
    class Title
    {
        private string _sTitle;

        public string Head { get { return _sTitle; } set { _sTitle = value; } }

        public void Show()
        {
            Console.WriteLine($"Title: {Head}");
        }
    }
}
