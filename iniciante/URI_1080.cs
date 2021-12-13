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
            int p = 0, maior = -9999;
            for(int i = 0; i < 100; i++)
            {
                int aux = int.Parse(Console.ReadLine());
                if(aux > maior)
                {
                    maior = aux;
                    p = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(p+1);
        }
    }
}
