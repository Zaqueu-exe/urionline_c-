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
            int pn = 0, pp = 0, ip = 0, ine = 0, nu = 0;
            int[] aux = new int[n];
            for (int i = 0; i < n; i++)
            {
                aux[i] = int.Parse((Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                if (aux[i] > 0)
                {
                    if (aux[i] % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (aux[i] < 0)
                {
                    if (aux[i] % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
