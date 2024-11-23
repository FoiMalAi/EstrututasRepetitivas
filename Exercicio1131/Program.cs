namespace Exercicio1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int novoGrenal = 1;
            int somaG = 0;
            int somaI = 0;
            int somaEmpate = 0;
            int somaGrenal = -1;

            while (novoGrenal == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int gInter = int.Parse(vet[0]);
                int gGremio = int.Parse(vet[1]);

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

                somaGrenal = somaGrenal + novoGrenal;

                if (gGremio > gInter)
                {
                    somaG = somaG + 1;
                }
                else if (gGremio < gInter)
                {
                    somaI = somaI + 1;
                }
                else if (gGremio == gInter)
                {
                    somaEmpate = somaEmpate + 1;
                }   
            }
            Console.WriteLine(somaGrenal + " grenais");
            Console.WriteLine("Inter:" + somaI);
            Console.WriteLine("Gremio:" + somaG);
            Console.WriteLine("Empates:" + somaEmpate);

            if (somaG > somaI)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (somaG < somaI)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (somaG == somaI)
            {
                Console.WriteLine("Nao houve vencedor");
            }
            Console.ReadLine();
        }
    }
}
