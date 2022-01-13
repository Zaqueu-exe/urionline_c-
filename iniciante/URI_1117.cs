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

            int cont = 0;
            double m = 0;
            while(cont < 2)
            {
                double n = double.Parse(Console.ReadLine());
                if(n >= 0 && n <= 10)
                {
                    m += n;
                    cont++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine("media = " + (m/2.0).ToString("F2"));

        }
    }
}

