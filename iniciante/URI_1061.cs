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

            int totalSegundosI = horario();
            int totalSegundosF = horario();
            int aux = totalSegundosF - totalSegundosI;

            Console.WriteLine($"{aux / 86400} dia(s)"); aux %= 86400;
            Console.WriteLine($"{aux / 3600} hora(s)"); aux %= 3600;
            Console.WriteLine($"{aux / 60} minuto(s)"); aux %= 60;
            Console.WriteLine($"{aux} segundo(s)");

        }
        public static int horario()
        {
            String[] diaS = Console.ReadLine().Split(' ');
            int d = int.Parse(diaS[1]);
            string[] horarioi = Console.ReadLine().Split(':');
            int h = int.Parse(horarioi[0]);
            int m = int.Parse(horarioi[1]);
            int s = int.Parse(horarioi[2]);

            return ((((d * 24) + h) * 60) + m) * 60 + s;
        }
    }
}
