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
            while (continua)
            {
                double media = 0.0;
                int aux = 5;
                for(int i = 0; i < 2;)
                {
                    double nota = double.Parse(Console.ReadLine());

                    if(nota >= 0.0 && nota <= 10.0)
                    {
                        i++;
                        media += nota;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                Console.WriteLine("media = " + (media/2.0).ToString("F2"));
                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    aux = int.Parse(Console.ReadLine());
                    if(aux == 2)
                    {
                        continua = false;
                    }
                }while(aux != 1 && aux != 2);
            }
        }
    }
}

