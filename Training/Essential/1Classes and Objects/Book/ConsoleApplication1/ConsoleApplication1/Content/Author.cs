using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Content
{
    class Author
    {
        private string _sWriter;

        public string Writer { get { return _sWriter; } set { _sWriter = value; } }

        public void Show()
        {
            Console.WriteLine($"Author: {Writer}");
        }
    }
}
