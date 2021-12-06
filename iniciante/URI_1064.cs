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
            float md = 0;
            int qtd = 0;
            for(int i = 0; i < 6; i++){
                float aux = float.Parse(Console.ReadLine());
                if(aux > 0.0)
                {
                    qtd++;
                    md += aux;
                }
            }
            Console.WriteLine(qtd + " valores positivos");
            Console.WriteLine((md/qtd).ToString("F1"));

        }
    }
}
