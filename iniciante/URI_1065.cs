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
            int qtd = 0;
            for(int i = 0; i < 5; i++){
                int aux = int.Parse(Console.ReadLine());
                if(aux % 2 == 0)
                {
                    qtd++;
                }
            }
            Console.WriteLine(qtd + " valores pares");

        }
    }
}
