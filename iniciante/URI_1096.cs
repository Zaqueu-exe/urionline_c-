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
            int i = 1, j = 7;
            while(i <= 9)
            {
                for(int g = 0; g < 3; g++)
                {
                    Console.WriteLine($"I={i} J={j--}");

                }
                j = 7;
                i += 2;
            }

        }
    }
}

