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
            float n1 = float.Parse(a[0]);
            float n2 = float.Parse(a[1]);

            if (n1 == 0 || n2 == 0)
            {
                if (n1 != 0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (n2 != 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else
                {
                    Console.WriteLine("Origem");
                }

            }
            else if (n1 > 0)
            {
                if (n2 > 0)
                {
                    Console.WriteLine("Q1");
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
            else
            {
                if (n2 > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
        }
    }
}
