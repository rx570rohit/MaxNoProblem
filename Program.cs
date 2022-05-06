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
            Console.WriteLine(" Max integer:"+Max.MaximumIntegerNumber(1,5,6));
            Console.WriteLine("Max Float :"+Max.MaximumFloatNumber(8.6, 9.2, 4.5));
            Console.WriteLine("Max String :" + Max.MaximumStringNumber("my name", "is","Rohit"));
        }
    }
}