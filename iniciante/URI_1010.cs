using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1010
    {
        static void Main(String[] args)
        {

            String[] p1 = Console.ReadLine().Split(' ');
            String[] p2 = Console.ReadLine().Split(' ');

            double qtd1 = double.Parse(p1[1]);
            double preco1 = double.Parse(p1[2]);

            double qtd2 = double.Parse(p2[1]);
            double preco2 = double.Parse(p2[2]);

            Console.WriteLine("VALOR A PAGAR: R$ " + ((qtd1 * preco1)+ (qtd2 * preco2)).ToString("F2"));

        }
    }
}
