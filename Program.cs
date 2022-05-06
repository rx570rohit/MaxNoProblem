using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNoProblem
{
    internal class Program
    {
        public static void Main(String [] arg)
        {
            GenricsMax<int> intmax = new GenricsMax<int>(1,2,3);

            Console.WriteLine(intmax.MaxMethod());
        }
    }
}