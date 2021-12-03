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
            float renda = float.Parse(Console.ReadLine());

            if(renda <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            
            else if(renda <= 3000.0)
            {
                Console.WriteLine("R$ "+ ((renda-2000.0f)*0.08).ToString("F2"));
            }
            else if (renda <= 4500.0)
            {
                Console.WriteLine("R$ " + (80.0f + ((renda - 3000.0f) * 0.18)).ToString("F2"));
            }
            else
            {
                Console.WriteLine("R$ " + (80.0f + 270.0f + ((renda - 4500.0f) * 0.28)).ToString("F2"));
            }
        }
    }
}
