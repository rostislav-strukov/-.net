using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerMan
{
    class SpeakerENG : ASpeaker
    {
        string[] answersPrivet = new string[] { "Hello", "Dear Ms/Mrs/Mr", "Wats up" };
        string[] answersName = new string[] { "Jack", "LLcool J", "Babel", "Bros Pirs" };
        string[] answersBusinessStatus = new string[] { "Fine", "OKeY!", "My busines, all right" };
        string[] answerColor = new string[] { "Red", "Green", "Orange" };
        string[] answerGoodbye = new string[] { "Bye Bye", "See you soon", "Goodbye" };

        string _textEnter = null;

        public override string Name { get; set; }

        public override void GetAnswer()
        {
            Console.WriteLine("Hello, tell me about you greating?");
            GetHello();
            Console.WriteLine($"So, I propouse contact with you, my name is {answersName[new Random().Next(0, answersName.Length)]}, and you?");
            GetYouName();
            Console.WriteLine("Tell me about, you business status?");
            GetHowAreYou();
            Console.WriteLine("What you favourite color");
            GetCollor();
            Console.WriteLine("Thank you for conversation, but I take leave you, sorry :)");
            Goodbye();
        }

        public override void GetHello()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter} - maybe it's great! I'm write ({answersPrivet[new Random().Next(0, answersPrivet.Length)]})");
            }
            else
            {
                Console.WriteLine("So, you don't write anysing, please try again");

                GetHello();

                return;
            }
        }

        public override void GetYouName()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, nice to meet you!");
            }
            else
            {
                Console.WriteLine("So, you don't write anysing, please try again");

                GetYouName();

                return;
            }
        }

        public override void GetHowAreYou()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"{_textEnter}, business should have any status! ;)");
                Console.WriteLine($"А у меня дела.... скажу так: {answersBusinessStatus[new Random().Next(0, answersBusinessStatus.Length)]}");
            }
            else
            {
                Console.WriteLine("So, you don't write anysing, please try again");

                GetHowAreYou();

                return;
            }
        }

        public override void GetCollor()
        {
            _textEnter = Console.ReadLine();

            if (!String.IsNullOrEmpty(_textEnter))
            {
                Console.WriteLine($"My favourite color is {answerColor[new Random().Next(0, answerColor.Length)]}");
            }
            else
            {
                Console.WriteLine("So, you don't write anysing, please try again");

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
                Console.WriteLine("So, you don't write anysing, please try again");

                GetCollor();

                return;
            }
        }
    }
}
