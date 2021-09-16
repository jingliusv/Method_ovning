using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"stockholm", "kamera", "programmering", "dator" };
            HittaLangstaOrdet(words);
        }

        public static void HittaLangstaOrdet(string[] words)
        {
            int wordLength = 0;
            string longestWord = string.Empty;
            foreach (string word in words)
            {
                if(word.Length > wordLength)
                {
                    wordLength = word.Length;
                    longestWord = word;
                }                   
            }
            Console.WriteLine(longestWord);
        }
    }
}
