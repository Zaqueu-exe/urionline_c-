using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1038
    {
        static void Main(String[] args)
        {
            String[] a = Console.ReadLine().Split(' ');
            int opc = int.Parse(a[0]);
            int qtd = int.Parse(a[1]);

            if (opc == 1)
            {
                Console.WriteLine("Total: R$ " + (qtd * 4.00).ToString("F2"));
            }
            else if (opc == 2)
            {
                Console.WriteLine("Total: R$ " + (qtd * 4.50).ToString("F2"));
            }
            else if (opc == 3)
            {
                Console.WriteLine("Total: R$ " + (qtd * 5.00).ToString("F2"));
            }
            else if (opc == 4)
            {
                Console.WriteLine("Total: R$ " + (qtd * 2.00).ToString("F2"));
            }
            else if (opc == 5)
            {
                Console.WriteLine("Total: R$ " + (qtd * 1.50).ToString("F2"));
            }
        }
    }
}
