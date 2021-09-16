using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxVarde2(2, 5));
            Console.WriteLine(MaxVarde3(55, 5, 5));
            Console.WriteLine(KontrolleraMaxVarde(2, 9, 3)); 
        }

        public static int KontrolleraMaxVarde(int v1, int v2, int v3)
        {
            int max = 0;
            if (v1 == 0 || v2 == 0 || v3 == 0)
            {
                if (v1 == 0)
                    max = MaxVarde2(v2, v3);
                if (v2 == 0)
                    max = MaxVarde2(v1, v3);
                if (v3 == 0)
                    max = MaxVarde2(v1, v2);
            }
            else
                max = MaxVarde3(v1, v2, v3);
            return max;
        }

        public static int MaxVarde3(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 > v3)
                return v1;
            else if (v2 > v1 && v2 > v3)
                return v2;
            else
                return v3;      
        }

        public static int MaxVarde2(int v1, int v2)
        {
            return v1 > v2 ? v1 : v2;
        }
    }
}
