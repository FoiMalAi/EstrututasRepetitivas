using System.Runtime.Serialization;

namespace ExercicioResolvido04Uri1071
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int max, min, x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            int soma = 0;
            for (int i = min +1; i < max; i++)
            {                
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}
