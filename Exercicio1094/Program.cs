namespace Exercicio1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            int somaS = 0;
            int somaC = 0;
            int somaR = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int QtdExp = int.Parse(vet[0]);
                char SigCobaia = char.Parse(vet[1]);

                if (SigCobaia == 'C')
                {
                    somaC = somaC + QtdExp;
                }
                else if (SigCobaia == 'S')
                {
                    somaS = somaS + QtdExp;
                }
                else
                {
                    somaR = somaR + QtdExp;
                }
            }

            int Total = somaS + somaC + somaR;
            
            double porcentagemCoelhos = (double)somaC / Total * 100.0;
            double porcentagemRatos = (double)somaR / Total * 100.0;
            double porcentagemSapos = (double)somaS / Total * 100.0;


            Console.WriteLine("Total: " + Total + "cobaias");
            Console.WriteLine("Total de coelhos: " + somaC);
            Console.WriteLine("Total de ratos: " + somaR);
            Console.WriteLine("Total de sapos: " + somaS);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de coelhos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de coelhos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}
