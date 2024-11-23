﻿namespace Exercicio1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int novoCalculo = 1;
            
            while (novoCalculo == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }
                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                double media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2"));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo =  int.Parse(Console.ReadLine());

                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
