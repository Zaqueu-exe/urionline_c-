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
            for (int i = 0; i < 6; i++){
                float aux = float.Parse(Console.ReadLine());
                if(aux > 0.0f)
                {
                    qtd++;
                }
            }
            
            Console.WriteLine($"{qtd} valores positivos");

        }
    }
}
