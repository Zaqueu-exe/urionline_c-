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
            double soma = 0, idade = 0;
            int aux = -1;
            do
            {
                soma += idade;
                idade = int.Parse(Console.ReadLine());
                aux++;
            }while(idade > 0);
            Console.WriteLine((soma/aux).ToString("0.00"));

        }
    }
}

