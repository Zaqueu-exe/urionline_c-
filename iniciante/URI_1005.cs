using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1004
    {
        static void Main(String[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + (((n1 * 3.5) + (n2 * 7.5)) / 11).ToString("F5"));


        }
    }
}
