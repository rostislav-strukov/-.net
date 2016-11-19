using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerMan
{
    class SpeakerUKR : ASpeaker
    {
        string[] answersPrivet = new string[] { "Привiт", "Доброго дня", "Вітаю" };
        string[] answersName = new string[] { "Іван", "Олександр Іванович", "Пилипок" };
        string[] answersBuisenessStatus = new string[] { "Не погано", "Файно", "Все добре" };
        string[] answerColor = new string[] { "Червоний", "Зелений", "Помаранчевий" };
        string[] answerGoodbye = new string[] { "До побачення", "До зустрічі" };

        string _textEnter = null;

        public override string Name { get; set; }

        public override void GetAnswer()
        {
            Console.WriteLine("Привіт людина! Підкажи як ти здроваешься, а я тобі скажу як це роблю я");
            GetHello();
            Console.WriteLine($"Давай знайомитись, моє ім'я {answersName[new Random().Next(0, answersName.Length)]}, а тебе як?");
            GetYouName();
            Console.WriteLine("Ми вже із тобою знайомі, як твої справи?");
            GetHowAreYou();
            Console.WriteLine("Який твій любимий колір?");
            GetCollor();
            Console.WriteLine("Дякую тобі за бесіду, прийшов час прощатися");
            Goodbye();
        }

        public override void GetHello()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter} - це є добре, але я пишу з великої літери ({answersPrivet[new Random().Next(0, answersPrivet.Length)]})");
            }
            else
            {
                Console.WriteLine("Ну, а все ж такі як ти пишешь це!");

                GetHello();

                return;
            }
        }

        public override void GetYouName()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, дуже приємно будем знайомі!");
            }
            else
            {
                Console.WriteLine("Уточни будьласка, ти нечого не написав");

                GetYouName();

                return;
            }
        }

        public override void GetHowAreYou()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, справи вони такі можуть по різному бути! ;)");
                Console.WriteLine($"А мої справи виглядають таким чином: {answersBuisenessStatus[new Random().Next(0, answersBuisenessStatus.Length)]}");
            }
            else
            {
                Console.WriteLine("Уточни будьласка, ти нечого не написав");

                GetHowAreYou();

                return;
            }
        }

        public override void GetCollor()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"А мій любимий колір {answerColor[new Random().Next(0, answerColor.Length)]}");
            }
            else
            {
                Console.WriteLine("А напиши ещё разок, а то что-то я не разгледел");

                GetCollor();

                return;
            }
        }
        public override void Goodbye()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{answerGoodbye[new Random().Next(0, answerGoodbye.Length)]}");
            }
            else
            {
                Console.WriteLine("Уточни будьласка, ти нечого не написав");

                GetCollor();

                return;
            }
        }
    }
}
