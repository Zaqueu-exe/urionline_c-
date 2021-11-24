using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1021
    {
        static void Main(String[] args)
        {
            String[] aux = Console.ReadLine().Split(' ');
            int n1 =  int.Parse(aux[0]);
            int n2 = int.Parse(aux[1]);
            if(n1 > n2)
            {
                int aux1 = n2;
                n2 = n1;
                n1 = aux1;
            }

            if(n2 % n1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
