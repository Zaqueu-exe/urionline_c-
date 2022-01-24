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
            int v = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {v}");
                v *= 2;
            }

        }
    }
}

