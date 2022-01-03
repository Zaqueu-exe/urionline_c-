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
            int[] n1 = new int[n];
            int[] n2 = new int[n];
            for(int i = 0; i < n; i++)
            {
                String s = Console.ReadLine(); 
                String[] s1 = s.Split(' ');
                n1[i] = int.Parse(s1[0]);
                n2[i] = int.Parse(s1[1]);
            }
            for(int i = 0; i < n; i++)
            {
                int mn = n1[i], m = n2[i], aux = 0;
                if(n2[i] < n1[i])
                {
                    mn = n2[i];
                    m = n1[i];
                }
                for(int t = ++mn ; t < m; t++)
                {
                    if(t % 2 == 1)
                    {
                        aux += t;
                    }
                }
                Console.WriteLine(aux);
            }

        }
    }
}

