namespace Exercicio1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int A = int.Parse(valores[0]);
                int B = int.Parse(valores[1]);
                
                if (B == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = (double)A / (double)B;

                    Console.WriteLine(resultado.ToString("F1"));
                }                   
            }
        }
    }
}
