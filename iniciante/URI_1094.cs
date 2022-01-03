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
            int t = int.Parse(Console.ReadLine());
            int c = 0, r = 0, s = 0;
            for (int i = 0; i < t; i++)
            {
                String aux = Console.ReadLine();
                String[] aux1 = aux.Split(' ');
                if (aux1[1].Equals("S"))
                {
                    s += int.Parse(aux1[0]);
                }
                else if (aux1[1].Equals("R"))
                {
                    r += int.Parse(aux1[0]);
                }
                else
                {
                    c += int.Parse(aux1[0]);
                }
            }
            Console.WriteLine($"Total: {c + r + s} cobaias");
            Console.WriteLine($"Total de coelhos: {c}");
            Console.WriteLine($"Total de ratos: {r}");
            Console.WriteLine($"Total de sapos: {s}");
            Console.WriteLine("Percentual de coelhos: " + (c * 100.0 / (c + r + s)).ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + (r * 100.0 / (c + r + s)).ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + (s * 100.0 / (c + r + s)).ToString("F2") + " %");

        }
    }
}

