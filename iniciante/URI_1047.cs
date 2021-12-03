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
            int hi = int.Parse(aux[0]);
            int mi = int.Parse(aux[1]);
            int hf = int.Parse(aux[2]);
            int mf = int.Parse(aux[3]);
            int i = hi * 60 + mi;
            int f = hf * 60 + mf;
            if (i >= f)
            {
                f += 1440;
            }
            int tempo = f - i;
            Console.WriteLine($"O JOGO DUROU {tempo / 60} HORA(S) E {tempo % 60} MINUTO(S)");
        }
    }
}
