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
            int n1 = 0, n2 = 1;

            for(int i = 0; i < n-1; i++)
            {
                Console.Write(n1 + " ");
                n1 = n2 - n1;
                n2 = n1 + n2;
            }
            Console.WriteLine(n1);

        }
    }
}

