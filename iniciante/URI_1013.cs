using System;
namespace URI
{
    public class URI_1012
    {
        static void Main(String[] args){
            
            String[] aux = Console.ReadLine().Split(' ');
            int n1 = int.Parse(aux[0]);
            int n2 = int.Parse(aux[1]);
            int n3 = int.Parse(aux[2]);

            if(n1 >= n2 && n1 >= n3){
                Console.WriteLine(n1 + " eh o maior");
            }else if(n2 >= n1 && n2 >= n3){
                Console.WriteLine(n2 + " eh o maior");
            }else{
                Console.WriteLine(n3 + " eh o maior");
            }
        }
    }
}