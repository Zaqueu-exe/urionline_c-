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
            
            for(int i= 0; i < n; i++)
            {
                int anos = 0;
                double p1 = 0.0, p2 = 0.0;
                String[] aux = Console.ReadLine().Split(' ');
                p1 = double.Parse(aux[0]);
                p2 = double.Parse(aux[1]);
                double tx1 = double.Parse(aux[2]);
                double tx2 = double.Parse(aux[3]);
                tx1 = tx1 / 100.0;
                tx2 = tx2 / 100.0;
                while(p1 <= p2)
                {
                    p1 = Math.Floor(p1 + p1 * tx1);
                    p2 = Math.Floor(p2 + p2 * tx2);
                    anos++;
                    if(anos > 100)
                    {
                        break;
                    }
                }
                if(anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }
    }
}

