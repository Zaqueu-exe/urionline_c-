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
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
