using System;

namespace ListaExercicios.Exercicio05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine($"\nO volume da esfera é: {volume}");
            Console.ReadLine();
        }
    }
}