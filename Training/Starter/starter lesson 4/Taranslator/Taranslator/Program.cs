using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection translator = new NameValueCollection();

            translator.Add("привет", "hello");
            translator.Add("привет", "good morning");
            translator.Add("привет", "privet");


            string _word = Console.ReadLine();
            Random rnd = new Random();
            if (translator.AllKeys.Contains(_word))
            {
                //Console.WriteLine(rnd.Next(0, translator.Get(_word)));
                Console.WriteLine(translator.Get(_word).GetType());
            }




            Console.ReadKey();
        }
    }
}
