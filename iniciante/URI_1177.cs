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
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[1000];
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {i % n}");
            }

        }
    }
}

