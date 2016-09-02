using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEducationCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;

            UserCollection student = new UserCollection();
            List<UserCollection> students = new List<UserCollection>();

            do
            {
                Console.WriteLine("Coздадим студента");
                Console.WriteLine("Введите имя студента");
                student.Name = Console.ReadLine();
                Console.WriteLine("Введите возраст студента");
                student.Age = Convert.ToUInt32(Console.ReadLine());

                Dictionary<string, uint> dic = UserCollection.SubjectRate();

                students.Add(new UserCollection(student.Name, student.Age, dic));

                Console.WriteLine("Если вы хотите добавить ещё одиного студента нажмите 1 если нет нажмите 2:");
                check = Convert.ToInt32(Console.ReadLine());
                
                foreach (UserCollection item in students)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(item.Name + " " + item.Age);
                    foreach (KeyValuePair<string, uint> value in dic)
                    {
                        Console.WriteLine(value.Key + " " + value.Value);
                        foreach (var bal in item.Power())
                        {
                            for (int i = 0; i < bal.Length; i++)
                            {
                                Console.WriteLine(bal[i]);
                            }
                        }
                    }
                    Console.WriteLine("------------------------------------");
                }
            } while (check == 1);

            Console.ReadKey();          
        }

    //    Double _doubleMedium = default(Double);
    //        foreach (var item in GetRatings())
    //        {
    //            for (int i = 0; i<item.Length; i++)
    //            {
    //                _doubleMedium += item[i];
    //            }
    //doubleMedium = doubleMedium / item.Length;
    //        }
    }
}
