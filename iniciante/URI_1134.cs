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

            int gaso = 0, alco = 0, dies = 0, t = 0;

            do
            {
                t = int.Parse(Console.ReadLine());
                if(t == 1)
                {
                    alco++;
                }else if(t == 2)
                {
                    gaso++;
                }else if(t == 3)
                {
                    dies++;
                }

            }while (t != 4);
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ alco);
            Console.WriteLine("Gasolina: "+ gaso);
            Console.WriteLine("Diesel: "+ dies);
        }
    }
}

