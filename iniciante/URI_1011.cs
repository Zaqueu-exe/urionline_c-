using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1011
    {
        static void Main(String[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("VOLUME = "+ (4.0/3*3.14159*n1*n1*n1).ToString("F3"));

        }
    }
}
