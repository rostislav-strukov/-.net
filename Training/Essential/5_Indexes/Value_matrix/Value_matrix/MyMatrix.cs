using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_matrix
{
    class MyMatrix
    {
        int[,] matrix;
        
        public MyMatrix(int value1, int value2)
        {
            matrix = new int[Math.Abs(value1), Math.Abs(value2)];

            Console.WriteLine(matrix.Rank);
        }

        public void FillMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < matrix.Length i++)
            {
                for (int j = 0; j < value2; j++)
                {
                    matrix[i, j] = random.Next(10, 80);

                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}
