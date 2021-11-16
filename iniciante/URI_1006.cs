using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1006
    {
        static void Main(String[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + (((n1 * 2.0) + (n2 * 3.0) + (n3 * 5.0)) / 10).ToString("F1"));


        }
    }
}
