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
            int[] n = new int[2];
            n[0] = int.Parse(Console.ReadLine());
            n[1] = int.Parse(Console.ReadLine());
            int soma = 0;

            if(n[1] < n[0])
            {
                int aux = n[0];
                n[0] = n[1];
                n[1] = aux;
            }
            for(int i = n[0] + 1; i < n[1]; i++)
            {
                if(i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
