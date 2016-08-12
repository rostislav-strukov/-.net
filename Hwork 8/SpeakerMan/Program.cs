using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string _checkLanguage = null;

            Console.WriteLine("Пообщайся со мной!");
            Console.WriteLine();
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Если вы хотите говорить на русском введите букву p        |");
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Якщо ви хочете розмовляти україньською введіть букву у:   |");
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("If you want speak english please enter letter e:          |");
            Console.WriteLine(new String('-', 60));

            _checkLanguage = Console.ReadLine();

            switch (_checkLanguage)
            {
                case "p":
                    SpeakerRU russian = new SpeakerRU();
                    russian.Name = "Бот";
                    Console.WriteLine(new String('-', 15));
                    Console.WriteLine($"Привет я {russian.Name}   |");
                    Console.WriteLine(new String('-', 15));
                    russian.GetAnswer();
                    break;
                case "у":
                    SpeakerUKR ukrain = new SpeakerUKR();
                    ukrain.Name = "Бот";
                    Console.WriteLine(new String('-', 15));
                    Console.WriteLine($"Привіт я {ukrain.Name}    |");
                    Console.WriteLine(new String('-', 15));
                    ukrain.GetAnswer();
                    break;
                case "e":
                    SpeakerENG english = new SpeakerENG();
                    english.Name = "Bot";
                    Console.WriteLine(new String('-', 15));
                    Console.WriteLine($"Hello I'm {english.Name}  |");
                    Console.WriteLine(new String('-', 15));
                    english.GetAnswer();
                    break;
            }
            Console.ReadKey();

        }
    }
}
