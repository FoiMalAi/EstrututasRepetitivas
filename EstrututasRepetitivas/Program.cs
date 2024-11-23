namespace EstrututasRepetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, soma;

            n1 = int.Parse(Console.ReadLine());
            soma = 0;

            while (n1 != 0)
            {
                soma += + n1;
                n1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}

