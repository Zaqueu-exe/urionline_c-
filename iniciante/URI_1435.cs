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
                int aux = 1;
                for (int g = 0; g < n; g++)
                {
                    for (int i = aux-1; i < n-aux+1; i++)
                    {
                        for (int j = aux-1; j < n-aux+1; j++)
                        {
                            m[i, j] = aux;
                        }
                    }
                    aux++;
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

