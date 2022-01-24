using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            int[] n = new int[15];
            int[] p = new int[5];
            int[] im = new int[5];
            int cp = 0, ci = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
                if(n[i] % 2 == 0)
                {   
                    p[cp] = n[i];
                    cp++;
                }
                else
                {         
                    im[ci] = n[i];
                    ci++;
                }
                if (ci == 5 || i == 14)
                {
                    for (int t = 0; t < ci; t++)
                    {
                        Console.WriteLine($"impar[{t}] = {im[t]}");
                    }
                    ci = 0;
                }
                if (cp == 5 || i == 14)
                {
                    for(int t = 0; t < cp; t++)
                    {
                        Console.WriteLine($"par[{t}] = {p[t]}");
                    }
                    cp = 0;
                }
            }


        }
    }
}

