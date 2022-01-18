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
        
            int soma = 0;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }
            for(int i = n1; i <= n2; i++)
            {
                if(i %13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}

