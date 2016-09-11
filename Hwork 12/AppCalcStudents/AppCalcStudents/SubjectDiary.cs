using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalcStudents.Modules;
using AppCalcStudents;
using System.Xml.Serialization;
using System.IO;

namespace AppCalcStudents.Modules
{
    [Serializable]
    [XmlRoot("SubjectRepository")]
    public class SubjectDiary : Student
    {
        double _midlleRate = 0;

        Student student = new Student();

        [XmlIgnore]
        //[XmlArray("Subjects"), XmlArrayItem(typeof(Student[]), ElementName = "Subject")]
        public Dictionary<String, UInt32> subjects = new Dictionary<String, UInt32>();
        private TextWriter stream;

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

        public virtual void ShowSubject()
        {
            Console.WriteLine("---- список придметов ----");

            foreach (var item in subjects)
            {
                Console.WriteLine($"Предмет: {item.Key} Оценка: {item.Value}");
                foreach (var bal in GetMidleRate())
                {
                    for (int i = 0; i < bal.Length; i++)
                    {
                        _midlleRate += bal[i];
                    }
                    Console.WriteLine($"Средняя оценка по всем придметам ученика: {_midlleRate = _midlleRate / bal.Length}");
                }
            }
        }

        public IEnumerable<UInt32[]> GetMidleRate()
        {
            yield return subjects.Values.ToArray();
        }

        public void SerealizationDictuonary()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Student[]), new XmlRootAttribute() { ElementName = "Students" });

            serializer.Serialize(stream,
              subjects.Select(kv => new Student() { SubjectNew = kv.Key, Rate = kv.Value }).ToArray());
        }
    }
}
