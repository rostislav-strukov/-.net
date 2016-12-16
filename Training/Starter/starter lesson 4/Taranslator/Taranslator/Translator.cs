using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taranslator
{
    class Translator
    {
        NameValueCollection translator = new NameValueCollection();
        
        public void AddWords()
        {
            translator.Add("привет", "hello");
            translator.Add("привет", "good morning");
            translator.Add("привет", "privet");
        }

        //public string this[string index]
        //{
        //    get { return Key[index]}
        //    set { }
        //}
    }
}
