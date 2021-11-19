using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            int n1 = int.Parse(Console.ReadLine());
            int h = n1/3600; n1 = n1 % 3600;
            int m = n1/60; n1 = n1 % 60;
            Console.WriteLine($"{h}:{m}:{n1}");
        }
    }
}