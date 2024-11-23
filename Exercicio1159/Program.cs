using System.Runtime.InteropServices;

namespace Exercicio1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
           
            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x = x + 1;  //Nesse caso do numero impar, é somado mais um
                                //para se tonrnar um numero par.
                }

                int soma = 5 * x + 20;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
