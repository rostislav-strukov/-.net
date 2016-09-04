using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEducationCalc
{
    [Serializable]
    class UserCollection : SubjectTotal
    {
        private Dictionary<string, uint> dic;

        public string Name { get; set; }
        public uint Age { get; set; }

        public UserCollection(string name, uint age, Dictionary<string, uint> dic)
        {
            dic = dic;
            Name = name;
            Age = age;
        }

        public UserCollection()
        {
        }

        public static Dictionary<string, uint> SubjectRate()
        {
            int check;

            Dictionary<string, uint> dic = new Dictionary<string, uint>();
            do
            {
                Console.WriteLine("Введите предмет:");
                string subject = Console.ReadLine();
                Console.WriteLine("Введите оценку по предмету:", subject);
                uint rate = Convert.ToUInt32(Console.ReadLine());


                dic.Add(subject, rate);
                
                Console.WriteLine("Если вы хотите добавить ещё один предмет и оценку нажмите 1 если нет нажмите 2:");
                check = Convert.ToInt32(Console.ReadLine());
                
                foreach (var item in dic)
                {
                    Console.WriteLine($"Предмет:{item.Key + " " + "Оценка по предмету:" + item.Value}");
                }
            } while (check == 1);

            return dic;
        }

        public IEnumerable<uint[]> Power()
        {
             yield return dic.Values.ToArray();
        }
    }
}
