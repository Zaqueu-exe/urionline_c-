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
            string[] aux = Console.ReadLine().Split(' ');
            int x = int.Parse(aux[0]);
            int y = int.Parse(aux[1]);

            for (int i = 1; i <= y; i++)
            {

                Console.Write(i);
                if(i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }

            }

        }
    }
}

