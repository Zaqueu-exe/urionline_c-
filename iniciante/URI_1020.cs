using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            int n1 = int.Parse(Console.ReadLine());
            int a = n1/365; n1 = n1 % 365;
            int m = n1/30; n1 = n1 % 30;
            Console.WriteLine($"{a} ano(s)");
            Console.WriteLine($"{m} mes(es)");
            Console.WriteLine($"{n1} dia(s)");
        }
    }
}