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
            int n = int.Parse(Console.ReadLine());
            int aux = 0;
            while(aux < 6)
            {
                if(n % 2 == 1)
                {
                    aux++;
                    Console.WriteLine(n);
                }
                n++;
            }

        }
    }
}
