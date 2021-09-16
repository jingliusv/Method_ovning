using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "this is fun";
            Translate(ref text);
            Console.WriteLine(text);
        }

        public static void Translate(ref string text)
        {
            string vokal = "aeiouyåäö ";
            string newString = string.Empty;
            //StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                //if (vokal.Contains(text[i]))
                //    sb.Append(text[i]);
                //else
                //    sb.Append($"{text[i]}o{text[i]}");
                if (!vokal.Contains(text[i]))
                    newString += text[i] + "o" + text[i];
                else
                    newString += text[i];
            }
            text = newString;
            //text = sb.ToString();
        }
    }
}
