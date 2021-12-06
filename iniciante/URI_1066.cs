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
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            for (int i = 0; i < 5; i++){
                int aux = int.Parse(Console.ReadLine());
                if (aux % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (aux != 0)
                {
                    
                    if (aux > 0)
                    {
                        positivo++;
                    }
                    else
                    {
                        negativo++;
                    }
                }
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");

        }
    }
}
