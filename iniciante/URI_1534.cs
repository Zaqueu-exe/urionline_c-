using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            string str = Console.ReadLine();
            while (str != null)
            {
                int n = int.Parse(str);
                int[,] m = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        m[i, j] = 3;
                        if(i == j)
                        {
                            m[i, j] = 1;
                        }
                        if(j == n - i-1)
                        {
                            m[i, j] = 2;
                        }

                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write(m[i, j]);
                    }
                    Console.WriteLine();
                }
                str = Console.ReadLine();
                
            }
        }
    }
}

