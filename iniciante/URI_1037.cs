using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1037
    {
        static void Main(String[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a >= 0.0 && a <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (a > 25.0 && a <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (a > 50.0 && a <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (a > 75.0 && a <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
