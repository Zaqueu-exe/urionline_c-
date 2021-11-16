using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1008
    {
        static void Main(String[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("NUMBER = " + n1);
            Console.WriteLine("SALARY = U$ " + (n2 * n3).ToString("F2"));


        }
    }
}
