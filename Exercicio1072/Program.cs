using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;

namespace Exercicio1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < N; i++)
            {   
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    cont_in++;
                }
                else
                {
                    cont_out++;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}
