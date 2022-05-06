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
            int[] arr = { 112, 344, 432, 555, 678 }; GenricsMax<int> generic = new GenricsMax<int>(arr); generic.PrintMaxValue();


        }
    }
}