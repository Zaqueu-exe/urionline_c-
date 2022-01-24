using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            int[] v = new int[10];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] <= 0)
                {
                    v[i] = 1;
                }
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"X[{i}] = {v[i]}");
            }

        }
    }
}

