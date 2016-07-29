using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppScaut
{
    class Program
    {
        private static List<Scout> Scouts;
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------------Please choose you enter-----------------------------------------------------------------");
            Console.WriteLine("| Add scout enter 1 | Delete scout enter 2 | Add sport enter 3 | Delete sport enter 4 | Add aword scout enter 5 | Delete aword scout enter 6 | Show all scout enter 7 |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();

            SelectItems();
            CreateScout();

            Console.ReadKey();
        }

        public static void SelectItems()
        {
            char _iEnter = (char)Console.ReadKey().Key;

            switch (_iEnter) 
            {
                case '1': // добавить скаута
                    break;
                case '2': // удалить скаута
                    break;
                case '3': // добавить спорт 
                    break;
                case '4': // удалить спорт
                    break;
                case '5': // добавить награду
                    break;
                case '6': // удалить награду
                    break;
                case '7': // показать всех
                    break;
                default:
                    break;
            }
        }

        private static void CreateScout()
        {
            Scout _iScout;

            Console.WriteLine("Please enter sex of scout print in line Male - m or Female - f: ");

            char _iSex = Console.ReadLine()[0];

            switch (_iSex)
            {
                case 'm':
                    Console.WriteLine("Enter name for scout: ");
                    _iScout = new BoyScout(Console.ReadLine());
                    break;
                case 'f':
                    Console.WriteLine("Enter name for scout: ");
                    _iScout = new GirlScout(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Wrong enter");
                    return;
            }
            Scouts.Add(_iScout);
            Console.WriteLine($"Scout { _iScout.Name} added");
        }

        private static void AddSport()
        {

        }


    }

    class Scout
    {
        private string _iName;
        protected Sex _mySex;

        public string Name { get { return _iName; } set { _iName = value; } }

        public Sex MySex { get { return _mySex; } }
    }
    class BoyScout : Scout
    {
        public BoyScout(string _iName) : base(_iName)
        {
            _mySex = Sex._iMale; ;
        }
    }

    class GirlScout : Scout
    {
        public GirlScout(string _iName) : base(_iName)
        {
             _mySex = Sex._iFemale;
        }
    }

    class Sport
    {

    }

    class SportGirl
    {

    }

    class SportBoy
    {

    }

    enum Sex
    {
        _iMale = 'm',
        _iFemale = 'f'
    }
}
