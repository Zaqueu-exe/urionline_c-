using System; 

class URI {

    static void Main(string[] args) { 

        String[] aux = Console.ReadLine().Split(' ');
            float[] aux1 = { float.Parse(aux[0]), float.Parse(aux[1]), float.Parse(aux[2]) };
            float a, b, c;


            for (int i = 0; i < aux1.Length; i++)
            {
                for (int t = 1; t < aux1.Length; t++)
                {
                    if (aux1[t - 1] < aux1[t])
                    {
                        float aux2 = aux1[t - 1];
                        aux1[t - 1] = aux1[t];
                        aux1[t] = aux2;
                    }
                }
            }
            a = aux1[0];
            b = aux1[1];
            c = aux1[2];

            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            else
            {
                Console.WriteLine("NÃO FORMA TRIANGULO");
            }

            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
    }

}
