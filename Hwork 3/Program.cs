using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUsersLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // data about users
            string[] _iAdmin = {"admin", "passwordadmin"};
            string[] _iModerator = { "moderator", "passwordmoderator" };
            string[] _iUser = { "user", "passworduser" };

            
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

                if (_strLogin == _iAdmin[0] && _strPassword == _iAdmin[1]) // admin checkin
                {
                    Console.WriteLine("Hello admin");
                    break;
                }
                if (_strLogin == _iModerator[0] && _strPassword == _iModerator[1]) // moderator checkin
                {
                    Console.WriteLine("Hello moderator");
                    break;
                }

                if (_strLogin == _iUser[0] && _strPassword == _iUser[1]) // user checkin
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
