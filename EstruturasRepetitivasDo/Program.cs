namespace EstruturasRepetitivasDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c; 
            char repeticao;

            do
            {
                Console.Write("Digite a temperatura em Celcios: ");
                c = double.Parse(Console.ReadLine());
                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1"));
                Console.Write("Deseja repetir (s/n)? ");
                repeticao = char.Parse(Console.ReadLine());
            }
            while (repeticao == 's');  

        }
    }
}
