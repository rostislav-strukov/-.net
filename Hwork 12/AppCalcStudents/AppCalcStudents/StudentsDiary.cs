using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcStudents
{
    class StudentsDiary
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Name = "Jack",
                Age = 20
            },
            new Student()
            {
                Name = "Olsen",
                Age = 19
            },
            new Student()
            {
                Name = "Boris",
                Age = 17
            },
            new Student()
            {
                Name = "Vasiliy",
                Age = 85
            },
            new Student()
            {
                Name = "Chivas",
                Age = 18
            }
        };
    }
}
