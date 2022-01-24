using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Math.Round(n);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"N[{i}] = {Math.Round(n, 4)}");
                n /= 2;
            }

        }
    }
}

