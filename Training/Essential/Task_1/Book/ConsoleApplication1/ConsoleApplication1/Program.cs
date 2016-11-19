using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.InitializeObject();

            book.Writer = "Jeffry Richter";
            book.Title = "CLR via C#";
            book.Content = "C# tutorial";

            book.ShowAll();

            Console.ReadKey();
        }
    }
}
