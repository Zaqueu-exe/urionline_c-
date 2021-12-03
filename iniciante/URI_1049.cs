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
            String[] aux = new String[3];
            aux[0] = Console.ReadLine();
            aux[1] = Console.ReadLine();    
            aux[2] = Console.ReadLine();
            if (aux[0].Equals("vertebrado"))
            {
                if (aux[1].Equals("ave"))
                {
                    if (aux[2].Equals("carnivoro"))
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (aux[2].Equals("onivoro"))
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (aux[1].Equals("inseto"))
                {
                    if (aux[2].Equals("hematofago"))
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (aux[2].Equals("hematofago"))
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }

            }
        }
    }
}
