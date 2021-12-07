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
            for(int i = 2; i <= n; i = i+2)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {i*i}");
                }
            }
        }
    }
}
