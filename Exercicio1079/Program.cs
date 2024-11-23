namespace Exercicio1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0]);
                double b = double.Parse(valores[1]);
                double c = double.Parse(valores[2]);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                
                Console.WriteLine(media.ToString("F1"));

            }
        }
    }
}
