using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1046
    {
        static void Main(String[] args)
        {
            int i = 1, j = 60;
            while(j >= 0)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }

        }
    }
}

