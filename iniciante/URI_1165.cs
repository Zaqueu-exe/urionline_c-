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
            int aux = int.Parse(Console.ReadLine());
            for (int p = 0; p < aux; p++)
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == 1)
                {
                    Console.WriteLine(n + " eh primo");
                }
                else
                {
                    Console.WriteLine(n + " nao eh primo");
                }
            }
        }
    }
}

