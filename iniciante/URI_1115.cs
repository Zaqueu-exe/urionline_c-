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
            string[] aux = Console.ReadLine().Split(' ');
            int n1 = int.Parse(aux[0]);
            int n2 = int.Parse(aux[1]);


            while (n1 != 0 && n2 != 0)
            {

                if (n1 > 0)
                {
                    if (n2 > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (n2 > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else
                    {
                        Console.WriteLine("terceiro");
                    }
                }
                aux = Console.ReadLine().Split(' ');
                n1 = int.Parse(aux[0]);
                n2 = int.Parse(aux[1]);
            };

        }
    }
}

