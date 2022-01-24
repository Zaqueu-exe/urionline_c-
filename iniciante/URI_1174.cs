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
            double[] v = new double[100];
            
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i < v.Length; i++)
            {
                if(v[i] <= 10.0)
                {
                    Console.WriteLine($"A[{i}] = {v[i].ToString("0.0")}");
                }
            }

        }
    }
}

