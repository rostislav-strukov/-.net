using AppCalcStudents.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDiary students = new StudentsDiary();

            students.CreateStudents();
            Console.ReadKey();

        }
    }
}
