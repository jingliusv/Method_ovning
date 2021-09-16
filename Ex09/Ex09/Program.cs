using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en bokstav: ");
            string input = Console.ReadLine();
            if(CheckVokal(input))
                Console.WriteLine("Det är en vokal.");
            else
                Console.WriteLine("Det är inte en vokal.");
        }

        private static bool CheckVokal(string input)
        {
            bool isVokal = false;
            string[] vokal = { "a", "e", "i", "o", "u", "y", "å", "ä", "ö" };
            foreach(var letter in vokal)
            {
                if (letter.Equals(input))
                {
                    isVokal = true;
                    break;
                }              
                else
                    isVokal = false;
            }
            return isVokal;
        }
    }
}
