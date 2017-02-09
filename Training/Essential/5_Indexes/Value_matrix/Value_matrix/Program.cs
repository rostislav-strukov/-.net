using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMatrix myMatrix = new MyMatrix(10, 20);

            myMatrix.FillMatrix();

            Console.ReadKey();
            
        }
    }
}
