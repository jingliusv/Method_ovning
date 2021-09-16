using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Mata in din ålder: ");
                string input = Console.ReadLine();
                int age;
                if (!int.TryParse(input, out age))
                    throw new ArgumentException("Mata in ett nummer!");
                else
                    Console.WriteLine(CheckMindighet(age));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static string CheckMindighet(int age)
        {
            return age >= 18 ? "Du är myndig." : "Du är för ung!";
        }
    }
}
