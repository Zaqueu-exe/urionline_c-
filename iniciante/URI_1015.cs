using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            String[] p1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);

            String[] p2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(p2[0]);
            double y2 = double.Parse(p2[1]);

            Console.WriteLine((Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2))).ToString("F4"));
        }
    }
}