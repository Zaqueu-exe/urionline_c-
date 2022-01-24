using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            int tt = int.Parse(Console.ReadLine());
            int m = 9999999, p = 0, n = 0;
            string[] aux = Console.ReadLine().Split(' ');

            for (int i = 0; i < tt; i++)
            {
                n = int.Parse(aux[i]);
                if(n < m)
                {
                    m = n;
                    p = i;
                }
            }
            Console.WriteLine("Menor valor: " + m);
            Console.WriteLine("Posicao: "+ p);


        }
    }
}

