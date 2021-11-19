using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine((n1/n2).ToString("F3") + " km/l");
        }
    }
}