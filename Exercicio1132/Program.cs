using System.Runtime.Serialization;

namespace Exercicio1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int menor = x;
            int maior = y;

            if (x > y)
            {
                menor = y;
                maior = x;
               
            }

            int soma = 0;
            for (int i = menor; i <= maior; i++) 
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);


        }
    }
}
