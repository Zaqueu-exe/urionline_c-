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
            for(int i = 0; i < n; i++)
            {
                String[] aux = Console.ReadLine().Split(' ');

                int n1 = int.Parse(aux[0]);
                int n2 = int.Parse(aux[1]);
                
                if(n2 != 0)
                {
                    double aux1 = n1, aux2 = n2;
                    
                    Console.WriteLine((aux1/aux2).ToString("F1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }

        }
    }
}

