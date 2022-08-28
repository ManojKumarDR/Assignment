using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void process()
        {
            Console.WriteLine("The range of int is from:" + int.MinValue   +  "  to  "  +int.MaxValue);
            Console.WriteLine("The range of int is from:" + float.MinValue + "  to  " + float.MaxValue);
            Console.WriteLine("The range of int is from:" + short.MinValue + "  to " + short.MaxValue);
            Console.WriteLine("The range of int is from:" + long.MinValue + "  to  " + long.MaxValue);
            Console.WriteLine("The range of int is from:" + short.MinValue + "  to " + short.MaxValue);
            Console.WriteLine("The range of int is from:" + byte.MinValue + "  to  " + byte.MaxValue);
            Console.WriteLine("The range of int is from:" + uint.MinValue + "  to  " + uint.MaxValue);
            Console.WriteLine("The range of int is from:" + ushort.MinValue + "  to  " + ushort.MaxValue);

        }
        static void Main(string[] args)
        {
            process();
        }
    }
}
