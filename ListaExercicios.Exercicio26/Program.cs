using System;

namespace ListaExercicios.Exercicio26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero; 
            int fatorial = 1;

            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write($"\n{numero}! = ");
            for (int i = numero; i >= 1; i--)
            {
                Console.Write($"{i}");
                fatorial *= i;
                if (i > 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.Write($" = {fatorial}");
        }
    }
}