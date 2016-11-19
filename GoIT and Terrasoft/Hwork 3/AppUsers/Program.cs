using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            // data about users
            string[] _admin = { "admin", "passwordadmin" };
            string[] _moderator = { "moderator", "passwordmoderator" };
            string[] _user = { "user", "passworduser" };


            for (int i = 0; i <= 3; i++) // count for attempt
            {
                if (i == 3) // condition for attempts
                {
                    Console.WriteLine("You use more than 3 attempt");
                    break;
                }

                Console.WriteLine("Please enter your login");

                string _strLogin = Convert.ToString(Console.ReadLine()); // read LOGIN

                Console.WriteLine("Please enter your password");

                string _strPassword = Convert.ToString(Console.ReadLine()); // read PASSWORD


                if (_admin.Contains(_strLogin) && _admin.Contains(_strPassword)) // admin checkin
                {
                    Console.WriteLine("Hello admin");
                    break;
                }

                if (_moderator.Contains(_strLogin) && _moderator.Contains(_strPassword)) // moderator checkin
                {
                    Console.WriteLine("Hello moderator");
                    break;
                }

                if (_user.Contains(_strLogin) && _user.Contains(_strPassword)) // user checkin
                {
                    Console.WriteLine("Hello user");
                    break;
                }
                else if (i < 2) // condition for attemts before 3th attemt
                {
                    Console.WriteLine("Please try again you login or password");
                }
            }

            Console.ReadKey();
        }
    }
}
