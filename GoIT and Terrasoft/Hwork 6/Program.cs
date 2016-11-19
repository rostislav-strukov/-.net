using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScaut
{
    class Program
    {
        private static List<Scout> Scouts;

        static void Main(string[] args)
        {
            Scouts = new List<Scout>();

            ShowMenu();
            SelectMenuItem();
        }
        private static void CreateScout()
        {
            Scout _iScout;
            Console.Write("Please choose sex of scout Male - m or Female - f:");

            char sex = Console.ReadLine()[0];
            switch (sex)
            {
                case 'f':
                    Console.Write("Enter name of scout:");
                    _iScout = new GirlScout(Console.ReadLine());
                    break;
                case 'm':
                    Console.Write("Enter name of scout:");
                    _iScout = new BoyScout(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Wrong char");
                    return;
            }
            Scouts.Add(_iScout);
            Console.WriteLine($"New Scout '{_iScout.Name}' added.");
            Console.ReadKey();
        }

        private static void DeleteScout()
        {
            int _iCheck = 0;

            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"({_iCheck}) {i.Name}");
                _iCheck++;
            }

            Console.Write("Please choose scout in list:");

            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Scouts.Count - 1)
                Scouts.RemoveAt(_iIndex);
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
        }

        private static void AddSport()
        {
            int _iCheck = 0;

            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"({_iCheck}) {i.Name}");
                _iCheck++;
            }

            Console.Write("Please choose scout in the list");

            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Scouts.Count - 1)
                Console.WriteLine($"You choosed scout {Scouts[_iIndex].Name} ");
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
            Scouts[_iIndex].AddSport();
        }
        private static void AddAward()
        {
            int _iCheck = 0;

            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"({_iCheck}) {i.Name}");
                _iCheck++;
            }

            Console.Write("Please choose scout in list:");

            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Scouts.Count - 1)
                Console.WriteLine($"You choosed scout {Scouts[_iIndex].Name} ");
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
            ShowMenu();
            Scouts[_iIndex].AddProgress();
        }
        private static void DeleteSport()
        {
            int _iCheck = 0;

            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"({_iCheck}) {i.Name}");
                _iCheck++;
            }

            Console.Write("Please choose scout in list:");

            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Scouts.Count - 1)
                Console.WriteLine($"You choosed scout {Scouts[_iIndex].Name} ");
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
            Scouts[_iIndex].DeleteSport();
        }
        private static void DeleteAward()
        {
            int _iCheck = 0;

            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"({_iCheck}) {i.Name}");
                _iCheck++;
            }

            Console.Write("Please choose scout in list:");

            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Scouts.Count - 1)
                Console.WriteLine($"You choosed scout {Scouts[_iIndex].Name} ");
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
            ShowMenu();
            Scouts[_iIndex].DeleteAward();
        }

        private static void ShowAll()
        {
            foreach (Scout i in Scouts)
            {
                Console.WriteLine($"{ i.Name}({i.MySex})");
                foreach (Scout.Award j in i.GetProgress)
                {
                    Console.WriteLine($"Scout {j.Name} : {j.Points}");
                }
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        private static void ShowMenu()
        {
            Console.WriteLine("-------------------------------------------------------------------------------Please choose you enter-----------------------------------------------------------------");
            Console.WriteLine("| Add scout enter 1 | Delete scout enter 2 | Add sport enter 3 | Delete sport enter 4 | Add aword scout enter 5 | Delete aword scout enter 6 | Show all scout enter 7 |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        private static void SelectMenuItem()
        {
            char _iKey = Console.ReadLine()[0];

            Console.WriteLine();
            switch (_iKey)
            {
                case '1':  // добавить скаута
                    CreateScout();
                    break;
                case '2': // удалить скаута
                    DeleteScout();
                    break;
                case '3': // добавить спорт
                    AddSport();
                    break;
                case '4': // удалить спорт
                    DeleteSport();
                    break;
                case '5': // добавить награду
                    AddAward();
                    break;
                case '6': // удалить награду
                    DeleteAward();
                    break;
                case '7': // показать всех
                    ShowAll();
                    break;
            }
        }
    }
    abstract class Scout
    {

        private List<Award> Progress;
        private List<Sport> Sports;
        private string _iName;
        protected Sex _iSex;


        public string Name { get { return _iName; } set { _iName = value; } }
        public List<Award> GetProgress { get { return Progress; } }
        public Sex MySex { get { return _iSex; } }

        public List<Sport> GetSport { get { return Sports; } }

        public Scout(string _iName)
        {
            this._iName = _iName;
            Progress = new List<Award>();
        }
        public void AddProgress()
        {
            Progress = new List<Award>();
            Award NewAward = new Award();

            Console.Write("Please enter award: ");
            NewAward.Name = Console.ReadLine();

            Console.Write("Please enter score: ");
            NewAward.Points = Convert.ToByte(Console.ReadLine());

            Progress.Add(NewAward);

        }

        public void AddSport()
        {
            Sports = new List<Sport>();
            Sport NewSport = new Sport();

            Console.Write("Please enter Sport: ");
            NewSport.GetSport = Console.ReadLine();
            Sports.Add(NewSport);
        }
        public void DeleteSport()
        {
            int _iCheck = 0;

            foreach (Sport i in Sports)
            {
                Console.WriteLine($"({_iCheck}) {Sports[_iCheck].GetSport}");
                _iCheck++;
            }
            Console.WriteLine("Please choose sport in the list:");
            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Sports.Count - 1)
            {
                Console.WriteLine($"Delete {Sports[_iIndex].GetSport}");
                Sports.RemoveAt(_iIndex);
            }
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
        }

        public void DeleteAward()
        {
            int _iCheck = 0;
            foreach (Award i in Progress)
            {
                Console.WriteLine($"({_iCheck}) {Progress[_iCheck].Name}");
                _iCheck++;
            }
            Console.Write("Please choose award in the list:");
            int _iIndex = -1;

            if (int.TryParse(Console.ReadLine(), out _iIndex) && _iIndex <= Progress.Count - 1)
            {
                Console.WriteLine($"Delete {Progress[_iIndex].Name}");
                Progress.RemoveAt(_iIndex);
            }
            else
            {
                Console.WriteLine("Wrong index!");
                return;
            }
        }
        public class Sport
        {
            private string _iSport;

            public string GetSport { get { return _iSport; } set { _iSport = value; } }
        }
        public class Award
        {
            private string _iName;
            private int _iPoints;
            public string Name { get { return _iName; } set { _iName = value; } }
            public int Points { get { return _iPoints; } set { _iPoints = value; } }
        }
    }
    class GirlScout : Scout
    {
        public GirlScout(string _iName) : base(_iName) { _iSex = Sex.Female; }
    }
    class BoyScout : Scout
    {
        public BoyScout(string name) : base(name) { _iSex = Sex.Male; }
    }
    enum Sex
    { Male = 'm', Female = 'f' }
}
