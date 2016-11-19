using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerMan
{
    class SpeakerRU : ASpeaker
    {
        string[] answersPrivet = new string[] { "Привет", "Здраствуй", "Здраствуйте",  "Добрый день", "Добрый вечер", "Приветствую" };
        string[] answersName = new string[] { "ДиДжон", "Иннокентий", "Василий", "Радислав Бобер", "Энди Трольйсон" };
        string[] answersBuisenessStatus = new string[] { "отлично", "дела хорошо", "Все хорошо", "Устал конечно, но дела делаются" };
        string[] answerColor = new string[] { "Красный", "зеленый", "Металик", "оранжевый"};
        string[] answerGoodbye = new string[] { "До свидания", "Пока и до встречи", "Всего доброго до встречи" };

        string _textEnter = null;

        public override string Name { get; set; }

        public override void GetAnswer()
        {
            Console.WriteLine("Привет человек! Как ты здороваешься со всеми напиши мне, а я напишу тебе как я это делаю!");
            GetHello();
            Console.WriteLine($"Тогда давай знакомиться, на самом деле меня зовут {answersName[new Random().Next(0, answersName.Length)]}, а тебя как?");
            GetYouName();
            Console.WriteLine("Ну раз мы уже познакомились, расскажи как твои дела обстаят?");
            GetHowAreYou();
            Console.WriteLine("Какой твой любимый цвет");
            GetCollor();
            Console.WriteLine("Спасибо что пообщался со мной пришло время прощаться");
            Goodbye();
        }

        public override void GetHello()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter} - это конечно хорошо даже может оригинально, но я пишу c большой буквы ({answersPrivet[new Random().Next(0, answersPrivet.Length)]})");
            } else
            {
                Console.WriteLine("Ну а все таки как ты правильно пишешь?");

                GetHello();

                return;
            }
        }

        public override void GetYouName()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, очень приятно будем знакомы!");
            } else
            {
                Console.WriteLine("Как уточни пожалуйста, четче пиши, не разобрал твою запись");

                GetYouName();

                return;
            }
        }

        public override void GetHowAreYou()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, дела такие они в разном состоянии могут прибывать! ;)");
                Console.WriteLine($"А у меня дела.... скажу так: {answersBuisenessStatus[new Random().Next(0, answersBuisenessStatus.Length)]}");
            }
            else
            {
                Console.WriteLine("А напиши ещё разок, а то что-то я не разгледел");

                GetHowAreYou();

                return;
            }
        }

        public override void GetCollor()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"А мой любимый цвет {answerColor[new Random().Next(0, answerColor.Length)]}");
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
                Console.WriteLine("А напиши ещё разок, а то что-то я не разгледел");

                GetCollor();

                return;
            }
        }
    }
}
