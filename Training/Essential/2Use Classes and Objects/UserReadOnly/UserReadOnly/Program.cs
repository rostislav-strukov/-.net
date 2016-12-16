using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Rostik", 15, "passworrd", "04.12.2016");
            User user2 = new User("Rostik", 15, "passworrd", "25.10.2016");

            user.ShowValue();
            user2.ShowValue();
        }
    }
}
