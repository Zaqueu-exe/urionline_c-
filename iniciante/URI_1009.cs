using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1009
    {
        static void Main(String[] args)
        {
            String nome = Console.ReadLine();
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("TOTAL = R$ " + ((n2*0.15+n1).ToString("F2")));


        }
    }
}
