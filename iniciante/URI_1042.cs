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
            String[] a = Console.ReadLine().Split(' ');
            int[] n = { int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]) };
            for (int p = 0; p < n.Length; p++)
            {

                for (int i = 1; i < n.Length; i++)
                {
                    if (n[i - 1] > n[i])
                    {
                        int aux = n[i];
                        n[i] = n[i - 1];
                        n[i - 1] = aux;
                    }
                }
            }
            
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (String i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
