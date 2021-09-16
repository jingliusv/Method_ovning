using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 8;
            OutMethod(out num1, out num2);
            Console.WriteLine($"num1: {num1} num2: {num2}");
            RefMethod(ref num1, ref num2);
            Console.WriteLine($"num1: {num1} num2: {num2}");
            
        }

        private static void OutMethod(out int num1, out int num2)
        {
            num2 = 10;
            num1 = 18;
        }

        private static void RefMethod(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 * num2;
        }
    }
}
