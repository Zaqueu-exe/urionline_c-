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
            for (int i = 1; i <= 100; i++)
            {
                s += 1.0 / i;
            }
            Console.WriteLine(s.ToString("0.00"));

        }
    }
}

