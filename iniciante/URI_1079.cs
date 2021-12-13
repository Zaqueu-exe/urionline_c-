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
            int n = int.Parse(Console.ReadLine());
            
            double[] md = new double[n];
            for(int i = 0; i < n; i++)
            {
                String[] aux = Console.ReadLine().Split(' ');
                md[i] = (double.Parse(aux[0]) * 2.0 + double.Parse(aux[1]) * 3.0 + double.Parse(aux[2]) * 5.0)/10.0;
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(md[i].ToString("F1"));
            }
        }
    }
}
