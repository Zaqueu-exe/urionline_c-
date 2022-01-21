using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            double s = 0;
            int aux1 = 1;
            for (int i = 1; i <= 39; i+=2)
            {
                double aux = i;

                s += aux/aux1;
                aux1 *= 2;
            }
            Console.WriteLine(s.ToString("0.00"));

        }
    }
}

