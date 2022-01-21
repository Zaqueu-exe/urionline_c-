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
            int qtd = int.Parse(Console.ReadLine());
            for (int p = 0; p < qtd; p++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                int n1 = int.Parse(aux[0]);
                int n2 = int.Parse(aux[1]);
                int s = 0;
                for (int i = n1; i < (n1+n2*2); i++)
                {
                    if (i % 2 != 0)
                    {
                        s += i;
                    }
                }

                Console.WriteLine(s);
            }

        }
    }
}

