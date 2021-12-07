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
            for(int i = 1; i <= 10000; i++)
            {
                if(i % n == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
