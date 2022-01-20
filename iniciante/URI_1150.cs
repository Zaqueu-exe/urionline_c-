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
            int x = int.Parse(Console.ReadLine());
            int n = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n <= x);
            int soma = 0;
            int qtd = 0;
            for(int i = x; i < n; i++)
            {
                soma += i;
                qtd++;
                if (soma > n)
                {
                    break;
                }        
            }
            Console.WriteLine(qtd);

        }
    }
}

