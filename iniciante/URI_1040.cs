using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1038
    {
        static void Main(String[] args)
        {
            String[] a = Console.ReadLine().Split(' ');
            float n1 = float.Parse(a[0]);
            float n2 = float.Parse(a[1]);
            float n3 = float.Parse(a[2]);
            float n4 = float.Parse(a[3]);
            float m = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;
            Console.WriteLine("Media: " + (m-0.01).ToString("F1"));
            if (m >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (m < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float nf = float.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + nf.ToString("F1"));

                if (((nf + m) / 2) >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + ((nf + m) / 2).ToString("F1"));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + ((nf + m) / 2).ToString("F1"));
                }

            }
        }
    }
}
