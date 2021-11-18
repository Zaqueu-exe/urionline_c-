using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            String[] aux = Console.ReadLine().Split(' ');
            double n1 = double.Parse(aux[0]);
            double n2 = double.Parse(aux[1]);
            double n3 = double.Parse(aux[2]);

            Console.WriteLine("TRIANGULO: " + ((n1*n3)/2).ToString("F3"));
            Console.WriteLine("CIRCULO: " + ((n3*n3)*3.14159).ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + (((n1+n2)*n3)/2).ToString("F3"));
            Console.WriteLine("QUADRADO: "+ (n2*n2).ToString("F3"));
            Console.WriteLine("RETANGULO: " + (n1*n2).ToString("F3"));
        }
    }
}