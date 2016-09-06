using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using AppCalcStudents;

namespace AppCalcStudents
{
    [Serializable]
    class StudentsDiary : IEnumerable
    {
        int _check = 0;

        Student student = new Student();
        SubjectDiary subjects = new SubjectDiary();

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
                _check = Convert.ToInt32(Console.ReadLine());
            } while (_check == 1);

            students.Add(new Student(student.Name, student.Age, subjects));
        }
        
        public void ShowStudents()
        {
            Console.WriteLine("---- СПИСОК СТУДЕНТОВ ----");
            Console.WriteLine(new string('-', 20));
            foreach (var item in students)
            {
                Console.WriteLine($"Имя студента: {item.Name} | Возраст студента {item.Age}");
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
