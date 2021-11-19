using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine((n1 / 100) + " nota(s) de R$ 100,00"); n1 = n1 % 100;
            Console.WriteLine((n1 / 50) + " nota(s) de R$ 50,00"); n1 = n1 % 50;
            Console.WriteLine((n1 / 20) + " nota(s) de R$ 20,00"); n1 = n1 % 20;
            Console.WriteLine((n1 / 10) + " nota(s) de R$ 10,00"); n1 = n1 % 10;
            Console.WriteLine((n1 / 5) + " nota(s) de R$ 5,00"); n1 = n1 % 5;
            Console.WriteLine((n1 / 2) + " nota(s) de R$ 2,00"); n1 = n1 % 2;
            Console.WriteLine((n1) + " nota(s) de R$ 1,00");
        }
    }
}