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
            Boolean continua = true;
            int inter = 0, grem = 0, emp = 0, tt = 0;

            while (continua)
            {
                tt++;
                string[] str = Console.ReadLine().Split(' ');
                if (int.Parse(str[0]) > int.Parse(str[1]))
                {
                    inter++;
                }
                else if (int.Parse(str[0]) < int.Parse(str[1]))
                {
                    grem++;
                }
                else
                {
                    emp++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int aux = int.Parse(Console.ReadLine());
                if (aux == 2)
                {
                    continua = false;
                }

            }
            Console.WriteLine(tt + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + grem);
            Console.WriteLine("Empates:" + emp);
            if(inter > grem)
            {
                Console.WriteLine("Inter venceu mais");
            }else if(grem > inter){
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}

