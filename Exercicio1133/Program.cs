namespace Exercicio1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maior = x;
            int menor = y;

            if (y > x)
            {
                maior = y;
                menor = x;
            }

            for (int i = menor; i < maior; i++)
            {
                if  (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
