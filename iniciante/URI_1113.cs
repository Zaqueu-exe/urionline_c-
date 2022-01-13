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
            int n1, n2;
            do
            {
                String[] aux = Console.ReadLine().Split(' ');
                n1 = int.Parse(aux[0]);
                n2 = int.Parse(aux[1]);
                if (n1 > n2)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine("Crescente");
                }
            } while (n1 != n2);

        }
    }
}

