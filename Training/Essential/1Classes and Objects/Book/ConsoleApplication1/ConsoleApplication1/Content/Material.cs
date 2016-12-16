using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Content
{
    class Material
    {
        private string _sContent;

        public string Content { get { return _sContent; } set { _sContent = value; } }

        public void Show()
        {
            Console.WriteLine($"Material: {Content}");
        }
    }
}
