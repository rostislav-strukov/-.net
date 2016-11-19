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
            Languages _checkLanguage;

            Console.WriteLine("Пообщайся со мной!");
            Console.WriteLine();
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Если вы хотите говорить на русском введите букву p        |");
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Якщо ви хочете розмовляти україньською введіть букву у:   |");
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("If you want speak english please enter letter e:          |");
            Console.WriteLine(new String('-', 60));

            _checkLanguage = GetLanguages(Console.ReadLine()[0]);

            switch (_checkLanguage)
            {
                case Languages._Ru:
                    SpeakerRU russian = new SpeakerRU();
                    russian.Name = "Бот";
                    Console.WriteLine(new String('-', 15));
                    Console.WriteLine($"Привет я {russian.Name}   |");
                    Console.WriteLine(new String('-', 15));
                    russian.GetAnswer();
                    break;
                case Languages._Ukr:
                    SpeakerUKR ukrain = new SpeakerUKR();
                    ukrain.Name = "Бот";
                    Console.WriteLine(new String('-', 15));
                    Console.WriteLine($"Привіт я {ukrain.Name}    |");
                    Console.WriteLine(new String('-', 15));
                    ukrain.GetAnswer();
                    break;
                case Languages._En:
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

        private static Languages GetLanguages(char _Ch)
        {
            if (_Ch == 'p')
            {
                return Languages._Ru;
            }
            if (_Ch == 'y')
            {
                return Languages._Ukr;
            }
            if (_Ch == 'e')
            {
                return Languages._En;
            }
            return Languages._doesntChek;
        }

        
    }

    enum Languages
    {
        _En = 'e',
        _Ru = 'p',
        _Ukr = 'y',
        _doesntChek = 0
    }
}
