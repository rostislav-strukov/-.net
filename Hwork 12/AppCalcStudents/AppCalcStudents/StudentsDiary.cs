using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using AppCalcStudents;
using System.Xml.Serialization;

namespace AppCalcStudents
{
    [Serializable]
    [XmlRoot("StudentsRepository")]
    public class StudentsDiary : Student, IEnumerable
    {
        private int _check = 0;

        public int Check { get { return _check;  } set { _check = value; } }

        public Student student = new Student();
        public SubjectDiary subjects = new SubjectDiary();
        
        [XmlArray("Students"), XmlArrayItem(typeof(Student), ElementName = "Student")]
        public List<Student> students = new List<Student>();

        public void CreateStudents()
        {
            Console.WriteLine("Coздадим студента");
            Console.WriteLine("Введите имя студента");
            student.Name = Console.ReadLine();
            Console.WriteLine("Введите возраст студента");
            student.Age = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Давайте добавим студенту предмет и оценку по предмету");
            do
            {
                Console.WriteLine("Введите предмет:");
                string _subject = Console.ReadLine();
                Console.WriteLine("Введите оценку попредмету");
                uint _rate = Convert.ToUInt32(Console.ReadLine());
                subjects.AddSubject(_subject, _rate);
                subjects.ShowSubject();
                Console.WriteLine("Если вы хотите добавить ещё один предмет нажмите цифру 1 если нет нажмите цифру 2:");
                Check = Convert.ToInt32(Console.ReadLine());
            } while (Check == 1);

            students.Add(new Student(student.Name, student.Age, subjects.SubjectNew, subjects.Rate));
        }

        public void ShowStudents()
        {
            Console.WriteLine("---- СПИСОК СТУДЕНТОВ ----");
            Console.WriteLine(new string('-', 20));
            foreach (var item in students)
            {
                Console.WriteLine($"Имя студента: {item.Name} | Возраст студента {item.Age}");
                subjects.ShowSubject();
            }
        }
        


        public Student this[int index]
        {
            get { return students[index]; }
            set { students.Insert(index, value); }
        }

        public int Count
        {
            get { return students.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new ConcreateEnumerator(this);
        }    
    }
}
