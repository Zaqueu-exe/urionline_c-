using System;

namespace uri.iniciante
{
    internal class URI_1046
    {
        public static void Main(String[] args)
        {
            
            string op = Console.ReadLine();
            double[,] m = new double[12, 12];
            double s = 0.0;
            int cont = 11;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int t = 0; t < m.GetLength(1); t++)
                {
                    m[i, t] = double.Parse(Console.ReadLine());
                    if(t > cont)
                    {
                        s += m[i, t];
                    }
                }
                cont--;
            }
            if (op.Equals("S"))
            {
                Console.WriteLine((s).ToString("0.0"));
            }
            else
            {
                Console.WriteLine((s/66.0).ToString("0.0"));
            }

        }
    }
}

