using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using AppCalcStudents;

namespace AppCalcStudents.Modules
{
    [Serializable]
    class SubjectDiary : Subject
    {
        
        Dictionary<String, UInt32> subjects = new Dictionary<String, UInt32>();

        public void AddSubject(string _subject, uint _rate)
        {
            Rate = _rate;
            SubjectNew = _subject;

            try
            {
                subjects.Add(SubjectNew, Rate);
            }
            catch (Exception)
            {

                Console.WriteLine($"Елемент {SubjectNew} уже добавлен");
            }
            
        }

        public void ShowSubject()
        {
            foreach (var item in subjects)
            {
                Console.WriteLine($"Предмет: {item.Key} Оценка: {item.Value}");
            }
        }

        public IEnumerable<UInt32[]> GetMidleRate()
        {
            yield return subjects.Values.ToArray();
        }
    }
}
