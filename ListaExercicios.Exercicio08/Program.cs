using System;

namespace ListaExercicios.Exercicio08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Informe o raio da lata de óleo: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da lata de óleo: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"\nO volume da lata de óleo é: {volume}");
            Console.ReadLine();
        }
    }
}