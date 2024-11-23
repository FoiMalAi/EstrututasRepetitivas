namespace Exercicio1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                int X = int.Parse(valor[0]);
                int Y = int.Parse(valor[1]);

                //Essa sequencia implica sempre n varial "X" recebendo sempre
                //  o menor valor.

                if (X > Y)
                {
                    int aux = X;
                    X = Y;
                    Y = aux;
                }

                int soma = 0;
                for (int j = X + 1; j < Y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
            
        }
    }
}
