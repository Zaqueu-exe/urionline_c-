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
            while(n != 0)
            {
                for (int i = 1; i < n; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(n);
                n = int.Parse(Console.ReadLine());
                
            }

        }
    }
}

