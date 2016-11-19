using AppCalcStudents.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppCalcStudents
{
    public class Program
    {
        static void Main(string[] args)
        {

            SubjectDiary subjects = new SubjectDiary();
            Student student = new Student();
            StudentsDiary students = new StudentsDiary();
            do
            {
                students.CreateStudents();
                
                Console.WriteLine("Если вы хотите добавить ещё одинго студента нажмите цифру 1 если нет нажмите цифру 2:");
                students.Check = Convert.ToInt32(Console.ReadLine());



                FileStream stream = new FileStream("Students.xml", FileMode.Create, FileAccess.Write, FileShare.Read);

                XmlSerializer serializer = new XmlSerializer(typeof(StudentsDiary));

                serializer.Serialize(stream, students);

                stream.Close();

                Console.WriteLine("Обьект сереализован");

                subjects.SerealizationDictuonary();

                Console.ReadKey();

            } while (students.Check == 1);
        }
    }
}
