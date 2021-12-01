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
            String[] aux = Console.ReadLine().Split(' ');
            int h1 = int.Parse(aux[0]);
            int h2 = int.Parse(aux[1]);

            if (h1 == h2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if(h1 < h2)
            {
                Console.WriteLine($"O JOGO DUROU {h2-h1} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {h2+24-h1} HORA(S)");
            }
        }
    }
}
