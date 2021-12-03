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
            float salario = float.Parse(Console.ReadLine());
            float aumento = 0;
            if (salario <= 400.0)
            {
                aumento = 0.15f;
            }
            else if (salario <= 800.0)
            {
                aumento = 0.12f;
            }
            else if (salario <= 1200.0)
            {
                aumento = 0.10f;
            }
            else if (salario <= 2000.0)
            {
                aumento = 0.07f;
            }
            else
            {
                aumento = 0.04f;
            }
            Console.WriteLine("Novo salario: "+ (salario + salario*aumento).ToString("F2"));
            Console.WriteLine("Reajuste ganho: "+ (salario*aumento).ToString("F2"));
            Console.WriteLine("Em percentual: "+ (aumento*100).ToString("F0") + " %");
        }
    }
}
