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
            decimal i = 0.0m, j = 1.0m;
            while (i <= 2)
            {
                for (int g = 0; g < 3; g++)
                {
                    if (i == 0 || i == 1 || i == 2)
                    {
                        Console.WriteLine($"I={i.ToString("F0")} J={(j + g).ToString("F0")}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i.ToString("F1")} J={(j + g).ToString("F1")}");
                    }


                }
                j += 0.2m;
                i += 0.2m;
            }

        }
    }
}

