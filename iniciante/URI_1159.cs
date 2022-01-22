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
            int  n= int.Parse(Console.ReadLine());
            
            while (n != 0)
            {
                int sum = 0;
                for (int i = n; i < (n + 10); i++)
                {
                    if(i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                n = int.Parse(Console.ReadLine());
                

            }
        }
    }
}

