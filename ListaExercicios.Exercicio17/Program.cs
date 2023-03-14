using System;

namespace ListaExercicios.Exercicio17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("\nA soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("\nA soma de A + B é maior ou igual a C.");
            }

            Console.ReadKey();
        }
    }
}