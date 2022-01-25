using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {

            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int[,] m = new int[n, n];
                int aux1 = 0; ;
                for (int i = aux1; i < n; i++)
                {
                    int aux = 1;
                    for (int j = i; j < n; j++)
                    {
                        m[i, j] = aux;
                        m[j, i] = aux;
                        aux++;

                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(String.Format("{0,3}", m[i, j]));
                        }
                        else
                        {
                            Console.Write(String.Format("{0,4}", m[i, j]));
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}

