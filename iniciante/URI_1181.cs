using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            int l = int.Parse(Console.ReadLine());
            string aux = Console.ReadLine();
            double soma = 0;
            double[,] m = new double[12, 12];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int t = 0; t < m.GetLength(1); t++)
                {
                    m[i, t] = double.Parse(Console.ReadLine());
                    if (l == i)
                    {
                        soma += m[i, t];
                    }
                }
            }
            if (aux.Equals("S")){
                Console.WriteLine(soma.ToString("0.0"));
            }
            else
            {
                Console.WriteLine((soma/12.0).ToString("0.0"));
            }

        }
    }
}

