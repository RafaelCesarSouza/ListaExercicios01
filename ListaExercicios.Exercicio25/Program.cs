using System;

namespace ListaExercicios.Exercicio25
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;

            Console.Write("Digite um número de 1 a 10: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i * numero}");
            }
        }
    }
}