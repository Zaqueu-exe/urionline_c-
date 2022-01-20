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
            int n = int.Parse(Console.ReadLine());
            int aux = 0;

            for (int i = 1; i < 9999999; i++)
            {
                
                if(i  % 4 == 0)
                {
                    Console.WriteLine("PUM");
                    aux++;

                    if(aux == n)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}

