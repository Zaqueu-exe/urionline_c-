using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1011
    {
        static void Main(String[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            int[] notas = { 100, 50, 20, 10, 5, 2};
            int[] moedas = { 100, 50, 25, 10, 5, 1};
            double[] moedas1 = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01};

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < notas.Length; i++)
            {
                int aux = 0;
                while (notas[i] <= n1)
                {
                    aux++;
                    n1 = n1 - notas[i];
                }
                Console.WriteLine($"{aux} nota(s) de R$ {notas[i]}.00");
            }
            n1 = n1 * 100.00001;
            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < moedas.Length; i++)
            {
                int aux = 0;
                while (moedas[i] <= n1)
                {
                    aux++;
                    n1 = n1 - moedas[i];
                }
                Console.WriteLine($"{aux} moeda(s) de R$ {moedas1[i]:F2}");
            }

        }
    }
}
