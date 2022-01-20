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
            String[] aux = Console.ReadLine().Split(' ');
            int n1 = int.Parse(aux[0]);
            int n2 = int.Parse(aux[1]);
            int soma = 0;
            int cont = 0;
            while(n2 < 1)
            {
                cont++;
                n2 = int.Parse(aux[cont]);
            }

            for(int i = 0; i < n2; i++)
            {
                soma = soma + i + n1;
            }
            Console.WriteLine(soma);

        }
    }
}

