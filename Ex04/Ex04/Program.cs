using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaculateTax(250)); ;
        }

        public static int CaculateTax(double input)
        {
            const double taxRate = 0.25;
            return Convert.ToInt32(input * taxRate);
        }
    }
}
