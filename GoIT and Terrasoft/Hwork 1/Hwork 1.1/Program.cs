using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // screening value of data types
            Console.WriteLine("Type byte: default value {0}, min {1}, max {2}", new byte(), byte.MinValue, byte.MaxValue);
            Console.WriteLine("Type sbyte: default value {0}, min {1}, max {2}", new sbyte(), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Type short: default value {0}, min {1}, max {2}", new short(), short.MinValue, short.MaxValue);
            Console.WriteLine("Type ushort: default value {0}, min {1}, max {2}", new ushort(), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Type long: default value {0}, min {1}, max {2}", new long(), long.MinValue, long.MaxValue);
            Console.WriteLine("Type ulong: default value {0}, min {1}, max {2}", new ulong(), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Type float: default value {0}, min {1}, max {2}", new float(), float.MinValue, float.MaxValue);
            Console.WriteLine("Type double: default value {0}, min {1}, max {2}", new double(), double.MinValue, double.MaxValue);
            Console.WriteLine("Type decimal: default value {0}, min {1}, max {2}", new decimal(), decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Type bool: default value {0}", new bool());
            Console.ReadKey();
        }
    }
}
