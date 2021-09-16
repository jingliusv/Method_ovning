using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatenateString("Hello", "World"));
        }

        private static string ConcatenateString(string v1, string v2)
        {
            return string.Format("{0} {1}", v1, v2);
        }
    }
}
