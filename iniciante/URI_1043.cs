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
            float a = float.Parse(aux[0]);
            float b = float.Parse(aux[1]);
            float c = float.Parse(aux[2]);

            if (((a - b) < c && c < (a + b)) && ((a - c) < b && b < (a + c)) && ((b - c) < a && a < (b + c)))
            {
                Console.WriteLine("Perimetro = " + (a+b+c).ToString("F1"));
            }
            else
            {
                Console.WriteLine("Area = " + (((a+b)*c)/2).ToString("F1"));
            }


        }
    }
}
