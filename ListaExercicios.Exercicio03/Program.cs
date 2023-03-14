using System;

namespace ListaExercicios.Exercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"\nO volume do cilindro é: {volume}");
            Console.ReadLine();
        }
    }
}