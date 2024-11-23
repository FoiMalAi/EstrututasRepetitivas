namespace Exercicio1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N =int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= N; i++)
            {
                int segundo = inicio + 1;
                int terceiro = segundo + 1;
                Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");

                inicio += 4;
            }
        }
    }
}
