using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1036
    {
        static void Main(String[] args)
        {
            String[] n = Console.ReadLine().Split(' ');
            double a = double.Parse(n[0]);
            double b = double.Parse(n[1]);
            double c = double.Parse(n[2]);

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }


        }
    }
}
