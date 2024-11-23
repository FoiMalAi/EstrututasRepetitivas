namespace ExercicioResolvido03Uri1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            // A variavel "i" sempre vai inicar com o primeiro valor da contagem 
            // Neste caso a variavel 'N' é o numero que eu vou digitar
            // O 'i' é a quantidade de vezez que a contagem vai se repetir (no caso até o i chegar a 10)

            for (int i = 1; i <= 10; i++)
            {
                int resultado = N * i;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}
