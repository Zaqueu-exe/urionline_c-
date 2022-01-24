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
            int[] v = new int[20];
            
            for (int i = v.Length-1; i > -1; i--)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < v.Length; i++)
            {

                    Console.WriteLine($"N[{i}] = {v[i]}");
                
            }

        }
    }
}

