using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1002
    {
        static void Main(String[] args)
        {
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine("A=" + ((area * area) * 3.14159).ToString("F4"));

        }
    }
}
