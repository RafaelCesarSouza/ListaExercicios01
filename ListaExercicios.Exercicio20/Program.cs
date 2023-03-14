using System;

namespace ListaExercicios.Exercicio20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nO número digitado é par.");
            }
            else
            {
                Console.WriteLine("\nO número digitado é ímpar.");
            }
        }
    }
}