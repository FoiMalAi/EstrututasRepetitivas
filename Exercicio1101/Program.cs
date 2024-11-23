using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace Exercicio1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            while (M > 0 && N > 0)
            {
                int menor = M;
                int maior = N;

                if (M > N)
                {
                    menor = N;
                    maior = M;
                }


                int soma = 0;

                for (int i = menor; i <= maior; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');
                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);
            }
        }
    }
}
