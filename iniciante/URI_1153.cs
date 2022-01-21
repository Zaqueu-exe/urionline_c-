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
            int s = 1;
            while(n > 1)
            {
                s = s * n;
                n--;
            }
            Console.WriteLine(s);
            

        }
    }
}

