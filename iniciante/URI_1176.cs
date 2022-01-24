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
            int[] v = new int[n];
            
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < v.Length; i++)
            {

                    Console.WriteLine($"Fib({v[i]}) = {fibonacci(v[i])}");
                
            }

        }
        public static long fibonacci(int valor)
        {
            long n1 = 0l, n2 = 1l;

            for(int i = 0; i < valor; i++)
            {
                n1 = n2 - n1;
                n2 = n2 + n1;
            }
            return n1;
        }
    }
}

