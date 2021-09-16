using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Multiply(numbers));
        }

        private static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }

        private static int Multiply(int[] numbers)
        {
            int multiply = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                multiply *= numbers[i];
            return multiply;
        }
    }
}
