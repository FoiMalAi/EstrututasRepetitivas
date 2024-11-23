using System.Runtime.Serialization;

namespace Exercicio1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;
            int idadeT = 0;
            int idade = int.Parse(Console.ReadLine());
            
            while (idade > 0)
            {
                idadeT = idadeT + idade;
                quantidade += 1;
                idade = int.Parse(Console.ReadLine());
            }

            double media = idadeT / (double)quantidade; 
            Console.WriteLine(media.ToString("F2"));

        }
    }
}
