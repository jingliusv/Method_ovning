using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett decimaltal mellan 1 och 0:");
            double input = Convert.ToDouble(Console.ReadLine());
            ToPercentage(input);
        }

        private static void ToPercentage(double input)
        {
            Console.WriteLine(input * 100 + "%");
        }
    }
}
