using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri.iniciante
{
    internal class URI_1046
    {
        static void Main(String[] args)
        {
            int mes = int.Parse(Console.ReadLine());
            String[] meses = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            Console.WriteLine(meses[mes-1]);
        }
    }
}
